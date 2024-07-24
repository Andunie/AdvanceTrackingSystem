using Microsoft.VisualBasic;

namespace AspireApp2.Web.Model
{
    public class Teminat
    {
        public int TeminatId { get; set; }
        public DateTime? TeminatMektubuTarihi { get; set; }
        public int? TeminatMektubuNo { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public string? TeminatMektubuDurumu { get; set; }
        public string? Banka { get; set; }
        public string? TeminatıGonderenFirma { get; set; }
        public decimal? TeminatTutari { get; set; }
        public string? TeminatParaBirimi { get; set; }
        public DateTime? TeminatBitisTarihi { get; set; }
        public string? Statement { get; set; }
    }
}
