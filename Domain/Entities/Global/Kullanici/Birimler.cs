using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities.Global.Kullanici
{
    public class Birimler : BaseEntity
    {
        public string Adi { get; set; }

        public string Acıklama { get; set; }
        [JsonIgnore]
        public virtual ICollection<Kullanicilar> Kullanicilar { get; set; }
    }
}
