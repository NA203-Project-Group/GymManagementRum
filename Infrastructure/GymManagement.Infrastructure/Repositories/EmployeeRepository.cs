using GymManagement.Application.Interfaces.Repositories;
using GymManagement.Domain.Entities;
using GymManagement.Infrastructure.Contexts;

namespace GymManagement.Infrastructure.Repositories
{
    public class EmployeeRepository : RepositoryBase<EmployeeDetail>, IEmployeeDetailRepository
        {
            public EmployeeRepository(GymManagementDBContext context) : base(context)
            {

            }

        }
}