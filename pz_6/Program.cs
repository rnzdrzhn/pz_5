namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину отрезка А");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину отрезка В");
            int b = Convert.ToInt32(Console.ReadLine());
            int d = b;

            while (a - b > 0)
            {
                b = b + d;
            }

            b = b - d;
            Console.WriteLine("Длина незанятой части отрезка А = " + (a - b));
        }
    }
}