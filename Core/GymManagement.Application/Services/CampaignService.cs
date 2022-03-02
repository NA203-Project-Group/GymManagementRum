using AutoMapper;
using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.Interfaces.UnitOfWorks;
using GymManagement.Application.ViewModels.CampaignViewModel;
using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Services
{
    public class CampaignService : ICampaignService
    {
        private readonly IUnitOfWork _unitfOfWork;
        private readonly IMapper _mapper;
        public CampaignService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitfOfWork = unitOfWork;
            _mapper = mapper;
                
                
                
        }
        public List<CampaignQueryViewModel> GetAll()
        {
            var Campaigns = _unitfOfWork.Campaigns.GetAll();
            return _mapper.Map<List<CampaignQueryViewModel>>(Campaigns);
        }
        public bool Create(CampaignCommandViewModel model)
        {
            var campaign = _mapper.Map<Campaign>(model);
            _unitfOfWork.Campaigns.Create(campaign);
           
            if (_unitfOfWork.SaveChanges())
            {
                return true;
            }
            return false;

        }


        public bool Update(CampaignCommandViewModel model)
        {
            throw new NotImplementedException();
        }

        public CampaignQueryViewModel GetById(int id)
        {
            var campaign =_unitfOfWork.Campaigns.GetById(id);
            return _mapper.Map < CampaignQueryViewModel > (campaign);

                
        }
       
    }
}
