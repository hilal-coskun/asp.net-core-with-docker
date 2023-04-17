namespace ConoleDockerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            while (i<10)
            {
                Console.WriteLine("Hello, World! " + i);

                i++;
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}