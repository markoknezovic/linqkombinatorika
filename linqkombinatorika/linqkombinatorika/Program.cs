using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqkombinatorika
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = 100000000;
            int[] brojArray;
            while (true)
            {
                broj++;
                brojArray = Array.ConvertAll(broj.ToString().ToArray(), x => x - 48);
                if ((brojArray[0] + brojArray[1] + brojArray[2] + brojArray[3] + brojArray[4] + brojArray[5] + brojArray[6] + brojArray[7] + brojArray[8]) % 9 == 0)
                {
                    if ((brojArray[7] + brojArray[6] * 10 + brojArray[5] * 100) % 8 == 0)
                        if ((broj / 100) % 7 == 0)
                            if ((broj / 1000) % 6 == 0 && (brojArray[4] == 0 || brojArray[4] == 5))
                            {
                                if (((brojArray[2] * 10) + brojArray[3]) % 4 == 0)
                                {
                                    if ((brojArray[0] + brojArray[1] + brojArray[2]) % 3 == 0)
                                    {
                                        if ((brojArray[0] * 10 + brojArray[1]) % 2 == 0)
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                }
            }
            Console.WriteLine("Rjesenje je : " + broj);
            Console.ReadKey();
        }
    }
}