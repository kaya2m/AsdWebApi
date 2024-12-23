using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities.Global.Kullanici
{
    public class Kullanicilar : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string Gorev { get; set; }
        public string Sifre { get; set; }
        public string SifreHash { get; set; }
        public byte[] ProfilResmi { get; set; }

        [ForeignKey("Kullanici_Gruplar")]
        public int Grup_Id { get; set; }
        [ForeignKey("Birimler")]
        public int Birim_Id { get; set; }
        [ForeignKey("Gorevler")]
        public int Gorev_Id { get; set; }

        [JsonIgnore]
        public virtual Gruplar Gruplar { get; set; }
        [JsonIgnore]
        public virtual Birimler Birimler { get; set; }
        [JsonIgnore]
        public virtual Gorevler Gorevler { get; set; }
    }
}
