namespace PrintSpooler.ConApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<int, string> printSpooler = new PriorityQueue<int, string>();

            for (int i = 0; i < 25; i++)
            {
                int priority = RandomGenerator.Next(1, 100);

                printSpooler.Push(priority, String.Format("Druckauftrag #{0,-3} mit der Priorität {1}", i + 1, priority));
            }

            Console.WriteLine("Abarbeitung der Druckaufträge:");
            Console.WriteLine("------------------------------");

            while (printSpooler.IsEmpty == false)
            {
                Console.WriteLine(printSpooler.Pop());
            }
        }
    }
}