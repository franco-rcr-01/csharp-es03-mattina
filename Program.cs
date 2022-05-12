using System;

namespace csharp_es03_mattina // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMessage.AppendMessage("Nel mezzo del cammin di nostra vita mi ritrovai per una selva oscura ...");


            //Questo funziona con classe e metodi statici (ho un solo borsellino)
            {
                //due modi di leggere a terminale un numero e assegnarlo a una variabile
                int valore;
                //while (int.TryParse(Console.ReadLine(), out valore))
                string sValore = Console.ReadLine();
                valore = Convert.ToInt32(sValore);
                while (valore != 0)
                {
                    Console.WriteLine(Borsellino.Add(valore));
                    sValore = Console.ReadLine();
                    valore = Convert.ToInt32(sValore);
                }
            }

            //Questo funziona con N borsellini (classe e metodi non statici)
            {
                Salvadanaio salva1 = new Salvadanaio();
                Salvadanaio salva2 = new Salvadanaio();

                int valore;
                while (int.TryParse(Console.ReadLine(), out valore))
                {
                    Console.WriteLine("1: {0}", salva1.Add(valore)); //questo scrive nel totale dell'oggetto salva1

                    valore= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2: {0}", salva2.Add(valore)); //questo scrive nel totale dell'oggetto salva2
                }
            }
        }
    }
    //Aggiungete una classe che forma un borsellino, ogni volta che
    //chiamo il metodo Add(valore) il borsellino si incrementa del
    //valore passato come parametro e lo stampa a schermo
    //La classe la chiameremo Borsellino e il metodo int Add(int valore);
}
