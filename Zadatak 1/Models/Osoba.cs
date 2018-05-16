namespace Zadatak_1.Models
{
    public class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public override string ToString() => $"{Ime} {Prezime}";
    }
}