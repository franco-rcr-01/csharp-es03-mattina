using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_es03_mattina
{
    internal class ShowMessage
    {
        public static void AppendMessage(string testo)
        {
            //Prima implementazione (ricorsiva)
            //if (testo.Length > 10)
            //{
            //    Console.WriteLine(testo.Substring(0, 10));
            //    AppendMessage(testo.Substring(10));
            //} else {
            //    Console.WriteLine(testo);
            //}

            ////Seconda implementazione (iterativa)
            ////E se lo chiamassi con AppendMessage("zio paperone")????
            //while (testo.Length > 10)   //testo.lenght = 12, l seconda volta testo.legth vale 2!!!! e quindi esce
            //{
            //    Console.WriteLine(testo.Substring(0, 10)); //prendo i primo 10 della stringa: "zio papero"
            //    testo = testo.Substring(10);  //substring(10) prende i caratteri dal decimo in poi: "ne"
            //}
            //Console.WriteLine(testo);


            //Terza implementazione (iterativa sui singoli caratteri)
            int pos = 0;
            foreach (char c in testo)  //Sempreesempio di "Zio paperone"
            {
                if (pos == 10)
                {
                    Console.WriteLine();
                    pos = 0;
                }
                Console.Write(c);
                pos++;
            }
        }
    }
}
