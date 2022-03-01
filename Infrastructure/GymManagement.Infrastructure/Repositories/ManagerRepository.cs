using GymManagement.Application.Interfaces.Repositories;
using GymManagement.Domain.Entities;
using GymManagement.Infrastructure.Contexts;

namespace GymManagement.Infrastructure.Repositories
{
    public class ManagerRepository : RepositoryBase<Employee>, IManagerRepository
    {
        public ManagerRepository(GymManagementDBContext context) : base(context)
        {

        }

    }
}