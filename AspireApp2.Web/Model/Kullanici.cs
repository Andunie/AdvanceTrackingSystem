using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspireApp2.Web.Model
{
    [Table("Kullanicilar")]
    public class Kullanici
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KullaniciId { get; set; }
        public string? KullaniciAd { get; set; }
        public string? KullaniciSoyad { get; set; }
        public string? KullaniciSifre { get; set; }
        public string? KullaniciRol { get; set; }
        public int RolID { get; set; }
    }
}
