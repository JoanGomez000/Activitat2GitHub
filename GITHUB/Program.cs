using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITHUB
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar_programa = 'S';
            do
            {
                Console.WriteLine("|**********************************|");
                Console.WriteLine("|*                                *|");
                Console.WriteLine("|*  1 - Exàmen de conduir:        *|");
                Console.WriteLine("|*  2 - Exàmen de matemàtiques:   *|");
                Console.WriteLine("|*  3 - Exàmen de programació:    *|");
                Console.WriteLine("|*                                *|");
                Console.WriteLine("|**********************************|");

                char opcio_triar = char.Parse(Console.ReadLine());

                switch (opcio_triar)
                {
                    case '1':
                        {
                            Console.Clear();
                            PreguntaConduir1();
                            Console.ReadKey();
                        }
                        break;
                    case '2':
                        {
                            Console.Clear();
                            PreguntaProgramacio();
                            Console.ReadKey();
                        }
                        break;
                    case '3':
                        {
                            Console.Clear();
                            PreguntaBaseDeDades();
                            Console.ReadKey();
                        }
                        break;
                }

                Console.Clear();
                Console.WriteLine("\n|*  Vols continuar? S/N");
                continuar_programa = char.Parse(Console.ReadLine());
                Console.Clear();
            } while (continuar_programa != 'N');
        }

    }
}
