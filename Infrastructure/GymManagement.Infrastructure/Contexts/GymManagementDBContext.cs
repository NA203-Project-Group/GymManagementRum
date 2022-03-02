using GymManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Infrastructure.Contexts
{
   public class GymManagementDBContext : DbContext
    {
        public GymManagementDBContext(DbContextOptions<GymManagementDBContext> options)
            :base(options)
        {
                
        }
        public DbSet<EmployeeDetail> EmployeeDetail { get; set; }
         public DbSet<Campaign> campaigns { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<ExerciseProgram> ExercisePrograms { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
       
        public DbSet<WorkerContract> WorkerContracts { get; set; }
        public DbSet<Mission> Missions { get; set; }
    }
}
