namespace ПЗ_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое задание");
            int k;
            for (k = 30; k <= 150; k+=15)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("Второе задание");
            char s;
            for (s = 'н'; s != '5'; s++)
            {
                Console.Write(s);
            }

            Console.WriteLine("\nТретье задание");
            int b;
            int c;
            for (b = 0; b < 10; b++)
            {
                for (c = 0; c < 6; c++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }


            Console.WriteLine("Четвертое задание");
            int f;
            for (f = 0; f <= 100; f++)
            {
                if (f % 18 == 0)
                    Console.Write(f + " ");
            }

            
            Console.WriteLine("\nПятое задание");
            int v;
            int m;
            for (v = 0, m = 35; m - v != 3; v++, m--)
                Console.WriteLine(m + " " + v);

            Console.WriteLine("работssssssssss с git");
        }
    }
}