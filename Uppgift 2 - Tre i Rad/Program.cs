using System;

class Program
{
    static void Main()
    {
        Console.Write("N ? ");
        int N = int.Parse(Console.ReadLine());

        int count = 0;

        for (int a = 1; a < N; a++)
        {
            //(a, a + 1, a + 2)
            int produkt = a * (a + 1) * (a + 2);

            if (produkt < N)
            {
                Console.WriteLine(produkt);
                count++;
            }
            else
            {
                break; 
            }
        }

        Console.WriteLine($"Svar: {count}");
    }
}



