using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] names ={ { "Rafal", "Krzysiek" }, {"Rafal", "Krzysiek" } };

            for (int i = 0; i < names.GetLength(0); i++)
            {
                for (int y = 0; y <2; y++)
                {
                    Console.WriteLine(names[i,y]);
                }

            }
            //for (int i=0; i<names.Length; i++)
            //{
            //    for (int y = 0; y < names.Length; y++)
            //    {
            //        Console.WriteLine( names[i,y] ); 
            //    }
               
            //}

            Console.Read();

        }
    }
}
