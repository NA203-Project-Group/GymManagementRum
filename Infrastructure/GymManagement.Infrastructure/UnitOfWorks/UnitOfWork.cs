using GymManagement.Application.Interfaces.Repositories;
using GymManagement.Application.Interfaces.UnitOfWorks;
using GymManagement.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Infrastructure.UnitOfWorks
{
   public class UnitOfWork :IUnitOfWork
    {
        //sadece ctorda set edilebilir
       private  readonly GymManagementDBContext _context;
        public ICampaignRepository Campaigns { get; }
        public IEmployeeDetailRepository EmployeeDetails { get; }
        public IEquipmentRepository Equipments { get; }
        public IExerciseProgramRepository ExercisePrograms { get; }
        public IManagerRepository Managers { get; }
        public IMemberRepository Members { get; }
        public IMissionRepository Missions { get; }
        public ITrainerRepository Trainers { get; }
        public IWorkerContractRepository WorkerContracts { get; }
       


        public UnitOfWork(ICampaignRepository campaigns, IEmployeeDetailRepository employeeDetails,
            IEquipmentRepository equipments, IExerciseProgramRepository exercisePrograms,
            IManagerRepository managers, IMemberRepository members, IMissionRepository missions,
            ITrainerRepository trainers, IWorkerContractRepository workerContracts,GymManagementDBContext context)
        {
            Campaigns = campaigns;
            EmployeeDetails = employeeDetails;
            Equipments = equipments;
            ExercisePrograms = exercisePrograms;
            Managers = managers;
            Members = members;
            Missions = missions;
            Trainers = trainers;
            WorkerContracts = workerContracts;
           
            _context = context;
        }

        public bool SaveChanges() //ok işareti return anlamına mı geliyo?
        {
            if (_context.SaveChanges() >0)
            {
                return true;
            }
            return false;
        }

    }
}
