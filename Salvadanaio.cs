namespace csharp_es03_mattina
{
    internal class Salvadanaio
    {
        private int totale;
        public int Add(int valore)
        {
            totale += valore; //totale = totale + valore;
            return totale;
        }
        public Salvadanaio()
        {
            totale = 0;
        }
    }
}