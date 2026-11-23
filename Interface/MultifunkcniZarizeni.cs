namespace Interface
{
    public class MultifunkcniZarizeni : IPripojitelne, ITiskarna, Iskener
    {
        public string Skenuj()
        {
            return "Naskenoval jsem dokument.";
        }

        public void Tiskni(string dokument)
        {
            Console.WriteLine("Tisknu dokument " + dokument);
        }

        public void Pripoj(string adresa)
        {
            Console.WriteLine("Pripojeno - IP adresa: " + adresa);
        }
    }
}