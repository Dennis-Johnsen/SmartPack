namespace SmartPack.Data
{
    public class Regelverk
    {
        public int RegelverkId { get; set; }
        public int KategoriId { get; set; }
        public required string Betingelse { get; set; }
        public char Verdi { get; set; }
        public bool TillatHandbagasje { get; set; }
        public bool TillatInnsjekketBagasje { get; set; }
        public int Beskrivelse { get; set; }
    }
}