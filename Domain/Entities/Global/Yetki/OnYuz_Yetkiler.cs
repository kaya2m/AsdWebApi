using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Global.Yetki
{
    public class OnYuz_Yetkiler : BaseEntity
    {
        public int DepartmanId { get; set; }
        public int ModulId { get; set; }
        public int EkranId { get; set; }
    }
}
