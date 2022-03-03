using GymManagement.Application.ViewModels.CampaignViewModel;
using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Interfaces.ServiceInterfaces
{
   public interface ICampaignService
    {
        //ihtiyaca göre şekillenen şeyler 
        //kampanyaları clienta öViewModeln yüze nasıl yansıtcaz?
        List<CampaignQueryViewModel> GetAll();//unitof alınca tüm repositorylari almış alıyoz??
        CampaignQueryViewModel GetById(int id);
        bool Create(CampaignCommandViewModel model );
        bool Update(CampaignCommandViewModel model, int id);
        bool Delete( int id);

    }
}
