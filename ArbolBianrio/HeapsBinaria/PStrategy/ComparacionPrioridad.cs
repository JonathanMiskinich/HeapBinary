using tpfinal;

namespace PStrategy
{
    public class ComparacionPrioridad : IComparacion
    {
        public int Compare(Proceso p, Proceso p1)
        {
            if (p.prioridad == p1.prioridad)
                return 0;
            else if (p.prioridad > p1.prioridad)
                return 1;
            else
                return -1;
        }
    }
}