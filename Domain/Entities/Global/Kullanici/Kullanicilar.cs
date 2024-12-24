using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities.Global.Kullanici
{
    [Table("ANA_Kullanicilar")]
    public class Kullanicilar : BaseEntity
    {
        [MaxLength(50)]
        public string Ad { get; set; }
        [MaxLength(50)]
        public string Soyad { get; set; }
        [MaxLength(15)]
        public string TC { get; set; }
        [MaxLength(50)]
        public string KullaniciAdi { get; set; }
        [MaxLength(50)]
        public string Mail { get; set; }
        [MaxLength(50)]
        public string Tel { get; set; }
        [MaxLength(50)]
        public string Gorev { get; set; }
        public string Sifre { get; set; }
        public byte[] ProfilResmi { get; set; }

        [ForeignKey("Departmanlar")]
        public int DepartmanId { get; set; }
        [ForeignKey("Gorevler")]
        public int GorevId { get; set; }

        [JsonIgnore]
        public virtual Departmanlar Departmanlar { get; set; }
        [JsonIgnore]
        public virtual Gorevler Gorevler { get; set; }
    }
}
