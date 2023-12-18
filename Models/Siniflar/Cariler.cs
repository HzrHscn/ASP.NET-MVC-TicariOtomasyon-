using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCOnlineTicariOtomasyon.Models.Siniflar
{
    public class Cariler
    {
        [Key]
        public int Cariid {get;set;}

        [Column(TypeName = "Varchar")]
        [StringLength(50,ErrorMessage ="En Fazla 50 Karakter Yazabilirsiniz!")]
        public string CariAd { get;set;}

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        [Required(ErrorMessage ="Bu Alanı Boş Geçemezsiniz!")]
        public string CariSoyad { get;set;}

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CariSehir { get;set;}

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CariMail { get;set;}

        public bool Durum {  get; set;}

        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}