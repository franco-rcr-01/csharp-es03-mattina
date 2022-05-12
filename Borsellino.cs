namespace csharp_es03_mattina
{
    internal class Borsellino
    {
        static int totale = 0;
        internal static int Add(int valore)
        {
            totale = totale + valore;
            return totale;
        }
    }
}