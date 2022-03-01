using GymManagement.Application.Interfaces.Repositories;
using GymManagement.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Infrastructure.DependenciesContainer
{
   public static class DependenciesContainer
    {
        public static  void AddInfraStructureServices (this IServiceCollection servicess)
        {
           servicess.AddScoped<ICampaignRepository,CampaignRepository>();
        }
    }
}
