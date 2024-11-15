using PStrategy;
using tpfinal;


namespace HeapBinaria
{
    public class MaxHeap : Heap
    {
        public MaxHeap(List<Proceso> l, IComparacion comp) : base(l, comp){}
        public MaxHeap() : base(){}

        protected override bool ChequearIntercambio(Proceso p, Proceso p2)
        {
            return Comparar(p, p2) == 1;
        }
    }
}