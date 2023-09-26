namespace praktika2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Из двоичной системы счисления в десятичную
            Console.WriteLine(Convert.ToInt32(Console.ReadLine(), 2));

            //Из десятичной системы счисления в двоичную
            Console.WriteLine(Convert.ToString(Convert.ToInt32(Console.ReadLine()), 2));

            //3 задание
            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
            int T = Convert.ToInt32(Console.ReadLine());

            M += T;
            N += M / 60;
            M = M % 60;
            N = N % 24;

            Console.WriteLine(N + ":" + M);
            //
            Console.ReadKey();
        }
    }
}