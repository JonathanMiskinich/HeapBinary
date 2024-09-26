using HeapBinaria;
using tpfinal;
using PStrategy;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            MaxHeap minHeap = new();

            minHeap.SetComparacion(new ComparacionPrioridad());

            List<Proceso> l = new(CreadorProcesos());
            minHeap.SetHeap(l);

            Console.WriteLine("MinHeap por Tiempo");
            foreach (Proceso item in minHeap.GetHeap)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            Proceso p = new Proceso("", new Random().Next(1000), new Random().Next(1000));
            minHeap.Insertar(p);
            foreach (Proceso item in minHeap.GetHeap)
            {
                Console.WriteLine(item);
            }

            MinHeapProceso minHeapDif = new();
            minHeapDif.SetComparacion(new ComparacionTiempo());
            minHeapDif.SetHeap(l);
            Console.WriteLine("MinHeap por Tiempo");
            foreach (Proceso item in minHeapDif.GetHeap)
            {
                Console.WriteLine(item);
            }
            minHeapDif.Insertar(p);
            Console.WriteLine("MinHeap por Tiempo");
            foreach (Proceso item in minHeapDif.GetHeap)
            {
                Console.WriteLine(item);
            }

        }
        public static List<Proceso> CreadorProcesos()
        {
            List<Proceso> procesos = new();
            for (int i = 0; i < 10; i++)
            {
                Proceso proceso = new Proceso("", new Random().Next(1000), new Random().Next(1000));
                procesos.Add(proceso);
            }
            return procesos;
        }
    }
}
