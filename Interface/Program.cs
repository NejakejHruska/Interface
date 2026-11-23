namespace Interface
{
    class Program
    {
        public static void Main(string[] args)
        {
            Tiskarna HP = new Tiskarna();
            Skener Canon = new Skener();
            MultifunkcniZarizeni Epson = new MultifunkcniZarizeni();

            HP.Tiskni("Vyplata.pdf");

            Console.WriteLine(Canon.Skenuj());

            Epson.Pripoj("192.168.8.10");
            Epson.Tiskni("Faktura.pdf");

            //Nemohu vytvářet instance rozhranní
            //IPripojitelne lan = new Ipripojitelne();

            ITiskarna seznamTiskaren = new Itiskarna[2];
            
            seznamTiskaren[0] = HP;
            seznamTiskaren[1] = Epson;
        }
    }
}