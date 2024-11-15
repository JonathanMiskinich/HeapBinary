using PStrategy;
using tpfinal;

namespace HeapBinaria
{
    public class MinHeapProceso : Heap
    {
        public MinHeapProceso(List<Proceso> l, IComparacion comp) : base(l, comp){}
        public MinHeapProceso() : base() {}

        protected override bool ChequearIntercambio(Proceso p, Proceso p2)
        {
            return Comparar(p, p2) == -1;
        }
    }
}