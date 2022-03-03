using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.ViewModels.EquipmentViewModel
{
   public class EquipmentCommandViewModel
    {
        public string Name { get; set; }
        public DateTime MaintenancePeriod { get; set; }//bakım periyotu 6 aylık
        public byte Duration { get; set; }//bakım geçerlilik süresi ay süresi aylık
        public bool IsActive { get; set; }
    }
}
