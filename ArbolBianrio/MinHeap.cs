using tpfinal;

namespace HeapBinaria
{
    public class MinHeapProceso : Heap
    {
        public MinHeapProceso(List<Proceso> l) : base(l){}
        public MinHeapProceso() : base() {}
        public override void UpHeap(int indice)
        {
            if (indice <= 0)
                return;

            if(Comparar(heap[indice], heap[IndicePadre(indice)]) < 0)
            {
                Intercambio(indice, IndicePadre(indice));
                UpHeap(IndicePadre(indice));
            }
        }
        public override void DownHeap(int indice)
        {
            if (EsHoja(indice))
                return;
            
            int hijoAIntercambiar = -1;

            if (TieneHijoDerecho(indice))
            {
                if(Comparar(heap[IndiceHijoDerecho(indice)], heap[IndiceHijoIzq(indice)]) < 0)
                {
                    if(Comparar(heap[IndiceHijoDerecho(indice)], heap[indice]) < 0)
                        hijoAIntercambiar = IndiceHijoDerecho(indice);
                }
                else if(Comparar(heap[IndiceHijoIzq(indice)], heap[indice]) < 0)
                    hijoAIntercambiar = IndiceHijoIzq(indice);
            }else
            {
                if(Comparar(heap[IndiceHijoIzq(indice)], heap[indice]) < 0)
                    hijoAIntercambiar = IndiceHijoIzq(indice);
            }

            if (hijoAIntercambiar != -1)
            {
                Intercambio(indice, hijoAIntercambiar);
                DownHeap(hijoAIntercambiar);
            }
        }
    }
}