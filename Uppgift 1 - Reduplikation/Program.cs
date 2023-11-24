using System;
using System.Linq;

class Progam
{
    static void Main()
    {
        Console.WriteLine("Ordet?");
        string Text = Console.ReadLine();
        int Lenght = Text.Length;

        Console.WriteLine("Upprepningar ?");
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {

            if(Text.Length > 10)
            {
                Console.WriteLine("Kan inte ha mer än nio bokstäver i ordet");
                break;
            }

    
            if(n > 9)
            {
                Console.WriteLine("får inte upprepas mer än nio gånger");
                break;
            }

            Console.Write(Text);
        }
    }
}