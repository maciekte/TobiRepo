using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class misiek
    {
        public static void Main(string[] args)
        {
            Solution1();
        }

        public static void Solution1()
        {
            bool bFinish = false;

            while (!bFinish)
            {
                Console.WriteLine("Wpisz jakiś tekst...");
                string InputText = Console.ReadLine();

                if (!InputText.Equals("koniec"))
                {
                    Console.WriteLine("Wpisano tekst {0}", InputText);
                }
                else
                {
                    bFinish = true;
                }
            }
        }
    }

}