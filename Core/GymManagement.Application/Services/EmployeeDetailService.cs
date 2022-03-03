using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.Interfaces.UnitOfWorks;
using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Services
{
    public class EmployeeDetailService : IEmployeeDetailService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeDetailService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public EmployeeDetail GetById(int id)
        {
            return _unitOfWork.EmployeeDetails.GetById(id);
                
        }
        public bool Create(EmployeeDetail model)
        {
            _unitOfWork.EmployeeDetails.Create(model);
            if (_unitOfWork.SaveChanges())
            {
                return true;
            }
            return false;
                
        }

        public bool Delete(int id)
        {
            var employeedetail = _unitOfWork.EmployeeDetails.GetById(id);
            employeedetail.IsDeleted = true;
            _unitOfWork.EmployeeDetails.Update(employeedetail);
            if (_unitOfWork.SaveChanges())
            {
                return true;
            }
            return false;
        }


        public bool Update(EmployeeDetail model, int id)
        {
             var employeedetail=_unitOfWork.EmployeeDetails.GetById(id);
            //employeedetail.FirstName = employeedetail.FirstName != default ? model.FirstName : employeedetail.FirstName;//tek satırda if
            _unitOfWork.EmployeeDetails.Update(model);
            if (_unitOfWork.SaveChanges())
            {
                return true;
            }
            return false;


        }
    }
}
