using HeapBinaria;
using tpfinal;
using PStrategy;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            MinHeapProceso minHeap = new();
            minHeap.SetComparacion(new ComparacionTiempo());
            minHeap.SetHeap(CreadorProcesos());
            foreach (Proceso item in minHeap.GetHeap)
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
