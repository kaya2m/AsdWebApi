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
    public class Menuler : BaseEntity
    {
        public string MenuAdi { get; set; }
        public string MenuIkon { get; set; }
        public string ControllerAdi { get; set; }
        public string ViewAdi { get; set; }
        [ForeignKey("Moduller")]
        public int Modul_Id { get; set; }
        public int Master_Id { get; set; }
        public int Detail_Id { get; set; }
        public int Child_Id { get; set; }
        public int SiraNo { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Moduller Moduller { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual OnYuz_Yetkiler Yetkiler { get; set; }
    }
}
