using tpfinal;

namespace HeapBinaria
{
    public class MinHeapProceso : Heap
    {
        public override void UpHeap(int indice)
        {
            
        }
        public override void DownHeap(int indice)
        {
            if (EsHoja(indice))
                return;
            
            int hijoAIntercambiar;

            if (TieneHijoDerecho(indice))
            {
                if(Comparar(heap[IndiceHijoDerecho(indice)], heap[IndiceHijoIzq(indice)]) < 0)
                {
                    if(Comparar(heap[indice], heap[IndiceHijoDerecho(indice)]) < 0)
                    {
                        Intercambio(indice, IndiceHijoDerecho(indice));
                        DownHeap(IndiceHijoDerecho(indice));
                    }
                }else if(Comparar(heap[indice], heap[IndiceHijoIzq(indice)]) < 0)
                {
                    Intercambio(indice, IndiceHijoIzq(indice));
                    DownHeap(IndiceHijoIzq(indice));
                }
            }else
            {
                if(Comparar(heap[indice], heap[IndiceHijoIzq(indice)]) < 0)
                {
                    Intercambio(indice, IndiceHijoIzq(indice));
                    DownHeap(IndiceHijoIzq(indice));
                }
            }
        }
    }
}