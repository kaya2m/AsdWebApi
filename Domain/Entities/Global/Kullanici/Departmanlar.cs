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
    [Table("ANA_Departmanlar")]
    public  class Departmanlar : BaseEntity
    {
        [MaxLength(50)]
        public string Adi { get; set; }
        [MaxLength(10)]
        public string Kod { get; set; }
        [MaxLength(250)]
        public string Acıklama { get; set; }

        [JsonIgnore]
        public virtual ICollection<Kullanicilar> Kullanicilar { get; set; }
        [JsonIgnore]
        public virtual ICollection<Gorevler> Gorevler { get; set; }
    }
}
