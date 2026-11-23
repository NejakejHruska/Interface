namespace Interface
{
    public class Tiskarna : IPripojitelne, ITiskarna
    {
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