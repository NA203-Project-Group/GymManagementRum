using GymManagement.Application.ViewModels.EquipmentViewModel;
using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Interfaces.ServiceInterfaces
{
   public interface IEquipmentService 
    {
        public List<Equipment> GetEquipmentsWithTrainer();//gösterilecek

        Equipment GetById(int id);
        bool Create(Equipment model);
        bool Update(Equipment model, int id);
        bool Delete(int id);

    }
}
