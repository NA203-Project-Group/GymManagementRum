using AutoMapper;
using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.Interfaces.UnitOfWorks;
using GymManagement.Application.ViewModels.EquipmentViewModel;
using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Services
{
    public class EquipmentService : IEquipmentService
    {
        private readonly IUnitOfWork _unitOfwork;
        private readonly IMapper _mapper;
        private EquipmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {

            _unitOfwork = unitOfWork;
            _mapper = mapper;
        }

        public bool Create(Equipment model)
        {
            _unitOfwork.Equipments.Create(model);
            if (_unitOfwork.SaveChanges())
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Equipment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<EquipmentQueryViewModel> GetEquipmentsWithTrainer()
        {
            var equipments = _unitOfwork.Equipments.GetEquipmentsWithTrainer();
            return _mapper.Map<List<EquipmentQueryViewModel>>(equipments);
        }

        public bool Update(Equipment model, int id)
        {
            throw new NotImplementedException();
        }

        List<Equipment> IEquipmentService.GetEquipmentsWithTrainer()
        {
            throw new NotImplementedException();
        }
    }
}
