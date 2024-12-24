using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities.Global.Kullanici
{
    [Table("ANA_Gorevler")]
    public class Gorevler : BaseEntity
    {
        [MaxLength(50)]
        public string Adi { get; set; }
        [MaxLength(250)]
        public string Acıklama { get; set; }
        [ForeignKey("Departmanlar")]
        public int DepartmanId { get; set; }
        [JsonIgnore]
        public virtual Departmanlar Departmanlar { get; set; }
        [JsonIgnore]
        public virtual ICollection<Kullanicilar> Kullanicilar { get; set; }
    }
}
