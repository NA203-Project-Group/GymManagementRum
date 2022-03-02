using GymManagement.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Interfaces.UnitOfWorks
{
  public  interface IUnitOfWork
    {

       //property olarak kullan
      ICampaignRepository Campaigns { get; } //sadece okuyabilsin toplu bir şekilde kaydetme unit of
      IEmployeeDetailRepository EmployeeDetails { get; } 
      IEquipmentRepository Equipments { get; }
      IExerciseProgramRepository ExercisePrograms { get; }
      IManagerRepository Managers { get; }
      IMemberRepository Members { get; }
      IMissionRepository Missions { get; }
      ITrainerRepository Trainers { get; }
     
      IWorkerContractRepository WorkerContracts { get; }
      bool SaveChanges();


    }
}
