namespace P016_UrunTanitim.Models
{
	public class Urun
	{
        /*!!! ->Bir Model sadece propertylerden olusmalidir ve fonksiyon olmaz Solid icin */
        public int  Id { get; set; }

        public string UrunKodu { get; set; }

        public string UrunTanim { get; set; }
        public int Miktar { get; set; } //node

        public string UrunTur { get; set; }

        public int MinStokSeviyesi { get; set; }

        public int MaxStokSeviyesi { get; set; }
    }
}
