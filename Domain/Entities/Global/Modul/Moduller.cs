using Domain.Entities.Global.Yetki;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities.Global.Modul
{
    [Table("ANA_Moduller")]
    public class Moduller : BaseEntity
    {
        public string ModulAd { get; set; }
        public string ModulRenk { get; set; }
        public string ModulIkon { get; set; }
        public string Acıklama { get; set; }
        public string  ModulURL { get; set; }
        
        public virtual List<Menuler> Menuler { get; set; }
    }
}
