using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WorkingWithArrays
{
    internal class yeArrays
    {
        public static void arraysgobrr()
        {
            string[] Allnames = {"jack","mark","Jass","El"};

            Random rnd = new Random();
            Thread.Sleep(4000);
            Random rnd2 = new Random();

            string rndNames = Allnames[rnd.Next(Allnames.Length)];
            string rndNames2 = Allnames[rnd2.Next(Allnames.Length)];


            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(rnd.Next());
               // Console.WriteLine(rndNames);
            }

            Console.WriteLine(rndNames);
            Console.WriteLine(rndNames2);

            Console.ReadKey();
        }
    }
}
