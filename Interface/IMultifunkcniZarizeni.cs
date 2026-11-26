namespace Interface
{
    public interface IMultifunkcniZarizeni : ITiskarna, Iskener, IPripojitelne
    {
        string Nazev { get; set; }
        string SerioveCislo { get; init; }
        bool JePripravenaKTisku => PocetPapiru > 0 && JePripojena;
    }
}