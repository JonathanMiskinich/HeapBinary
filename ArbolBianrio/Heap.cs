using tpfinal;
using PStrategy;

namespace HeapBinaria
{
    public abstract class Heap
    {
        protected List<Proceso> heap;
        protected IComparacion? comparar;
        public Heap()
        {
            this.heap = new List<Proceso>();
            this.comparar = null;
        }
        public Heap(List<Proceso> list)
        {
            this.comparar = null;
            this.heap = list;
            Heapify((list.Count / 2) - 1);
        }
        //Getters and Setters
        public List<Proceso> GetHeap
        {
            get {return this.heap;}
        }
        public void SetHeap(List<Proceso> l)
        {
            this.heap = l;
            Heapify((l.Count / 2) - 1);
        }
        public void SetComparacion(IComparacion c)
        {
            this.comparar = c;
        }
        // Metodos Principales
        public void Insertar(Proceso proceso)
        {
            heap.Add(proceso);
            UpHeap(heap.Count - 1);
        }
        public Proceso EliminarRaiz()
        {
            Proceso proc = heap[0];
            heap.Insert(0, heap[heap.Count - 1]);
            heap.RemoveAt(heap.Count - 1);
            DownHeap(0);
            return proc;
        }
        public Proceso ObtenerRaiz()
        {
            return this.heap[0];
        }
        public void Heapify(int i)
        {
            if (i < 0)
                return;
            else
            {
                DownHeap(i);
                Heapify(i-1);
            }
        }
        public bool EstaVacio()
        {
            return heap.Count == 0;
        }
        public int CantidadElementos()
        {
            return heap.Count;
        }
        public bool EsHoja(int indice)
        {
            return indice >= this.heap.Count/2; 
        }
        //Metodos Auxiliares
        protected void Intercambio(int indice, int i2)
        {
            Proceso temporal = heap[indice];
            heap[indice] = heap[i2];
            heap[i2] = temporal; 
        }
        public virtual void UpHeap(int indice){}
        public virtual void DownHeap(int indice){}
        protected static int IndiceHijoIzq(int i)
        {
            return (2*i) +1;
        }
        protected static int IndiceHijoDerecho(int i)
        {
            return (2*i) + 2;
        }
        protected static int IndicePadre(int i)
        {
            if (i != 0)
                return (i -1) / 2;
            return 0;
        }
        protected int? Comparar(Proceso p, Proceso p1)
        {
            if (comparar != null)
                return comparar.Compare(p, p1);
            else
                return null;
        }
        public bool TieneHijoIzquierdo(int indice)
        {
            int indiceHijoIzquierdo = IndiceHijoIzq(indice);
            if (indiceHijoIzquierdo <= heap.Count - 1)
                return true;
            else
                return false;
        }
        public bool TieneHijoDerecho(int indice)
        {
            int indiceHijoDerecho = IndiceHijoDerecho(indice);
            if (indiceHijoDerecho <= heap.Count - 1)
                return true;
            else
                return false;
        }
    }
}