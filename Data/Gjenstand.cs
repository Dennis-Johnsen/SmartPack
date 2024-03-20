namespace SmartPack.Data
{
    public class Gjenstand
    {
        public int GjenstandId { get; set; }
        public required string GjenstandNavn { get; set; }
        public required string Beskrivelse { get; set; }
        public int KategoriId { get; set; }
    }
}