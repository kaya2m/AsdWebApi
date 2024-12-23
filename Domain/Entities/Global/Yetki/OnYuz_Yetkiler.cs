using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Global.Yetki
{
    public class OnYuz_Yetkiler : BaseEntity
    {
        public int Kullanici_GrupId { get; set; }
        public int Modul_Id { get; set; }
        public int View_Id { get; set; }
    }
}
