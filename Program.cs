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
                        Console.WriteLine("introduza uma variavel x");
            int abcissa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduza uma variavel y");
            int ordenada = Convert.ToInt32(Console.ReadLine());
            if (abcissa > 0 && ordenada > 0)
            {
                Console.WriteLine("esta no primeiro quadrante");
            }
            else
            {
                if (abcissa > 0 && ordenada < 0)
                {
                    Console.WriteLine("esta no quarto quadrante");
                }
                else
                {
                    if (abcissa < 0 && ordenada < 0)
                    {
                        Console.WriteLine("esta no terceiro quadrante");
                    }
                    else
                    {
                        if (abcissa < 0 && ordenada > 0)
                        {
                            Console.WriteLine("esta no segundo quadrante");
                        }
                    }
        
        }
    }
}
