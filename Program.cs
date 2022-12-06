using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

             Console.Write  ("Zadejte pocet radku: ");
             int radky = int.Parse(Console.ReadLine());
             Console.Write("Zadejte tloustku bunky: ");
             int tloustka = int.Parse(Console.ReadLine());

                if (radky == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pocet radku s hodnotou nula neexsistuje");
                   
                }

                if (tloustka == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tlostka nula neexsistuje");

                }

                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < radky; i++)
                {
                  for (int k = 0; k < tloustka; k++)
                  {
                      Console.Write("+");
                  }

                  for (int k = 0; k < tloustka; k++)
                  {
                      Console.Write("-");
                  }

                  for (int k = 0; k < tloustka; k++)
                  {
                      Console.Write("+");
                  }

                  for (int k = 0; k < tloustka; k++)
                  {
                      Console.Write("-");
                  }

                  for (int k = 0; k < tloustka; k++)
                  {
                      Console.Write("+");
                  }

                      Console.WriteLine();
                   
                }

                Console.WriteLine();
                if (radky == 'n')
                {
                    Console.WriteLine("Konec");
                    break;

                }

                if (tloustka == 'n')
                {
                    Console.WriteLine("Konec");
                    break;
                }

            }

            Console.ReadLine();


        }
    }

           
    
}
