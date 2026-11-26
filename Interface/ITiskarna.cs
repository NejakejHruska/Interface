namespace Interface
{
    public interface ITiskarna
    {
        int PocetPapiru { get; }
        bool BarevnyTist { get; set; }
        void Tiskni(string dokument);
    }
}