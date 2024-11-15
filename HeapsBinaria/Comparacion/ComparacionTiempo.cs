using tpfinal;

namespace PStrategy
{
    public class ComparacionTiempo : IComparacion
    {
        public int Compare(Proceso p, Proceso p1)
        {
            if (p.tiempo == p1.tiempo)
                return 0;
            else if (p.tiempo > p1.tiempo)
                return 1;
            else
                return -1;
        }
    }
}