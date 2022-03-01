using GymManagement.Application.Interfaces.Repositories;
using GymManagement.Domain.Entities;
using GymManagement.Infrastructure.Contexts;

namespace GymManagement.Infrastructure.Repositories
{
    public class MissionRepository : RepositoryBase<Mission>, IMissionRepository
    {
        public MissionRepository(GymManagementDBContext context) : base(context)
        {

        }

    }
}