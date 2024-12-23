using Domain.Entities.Global.Yetki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities.Global.Modul
{
    public class Moduller : BaseEntity
    {
        public string ModulAd { get; set; }
        public string ModulRenk { get; set; }
        public string ModulIkon { get; set; }
        public string Acıklama { get; set; }
        public string  ModulURL { get; set; }

        
        public virtual List<Menuler> Menuler { get; set; }
        [JsonIgnore]
        public virtual OnYuz_Yetkiler Yetkiler { get; set; }
    }
}
