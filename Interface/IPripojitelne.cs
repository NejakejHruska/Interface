namespace Interface
{
    public interface IPripojitelne
    {
        bool JePripojena { get; set; }
        void Pripoj(string adresa);
    }
}