namespace Interface
{
    public class MultifunkcniZarizeni : IPripojitelne, ITiskarna, Iskener
    {
        public string Nazev { get; set; } = "Multifunkcni zarizeni";
        public string SerioveCislo { get; init; } = "";
        public int PocetPapiru { get; private set; } = 10;
        public bool BarevnyTist { get; set; } = true;
        public int RozliseniDpi { get; set; } = 300;
        public bool JePripojena { get; set; } = false;

        public MultifunkcniZarizeni(string nazev, string serioveCislo, int pocetPapiru, bool barevnyTist, int rozliseniDpi, bool jePripojena)
        {
            Nazev = nazev;
            SerioveCislo = serioveCislo;
            PocetPapiru = pocetPapiru;
            BarevnyTist = barevnyTist;
            RozliseniDpi = rozliseniDpi;
            JePripojena = jePripojena;
        }
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