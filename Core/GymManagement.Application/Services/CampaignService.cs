using AutoMapper;
using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.Interfaces.UnitOfWorks;
using GymManagement.Application.ViewModels.CampaignViewModel;
using GymManagement.Domain.Entities;
//using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        public List<CampaignQueryViewModel> GetAll() //istediğimiz kolonları göstermememe
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


        public bool Update(CampaignCommandViewModel model,int id)
        {
          var campaign =  _unitfOfWork.Campaigns.GetById(id);
            if (campaign is null)
            {
              throw new NotImplementedException("Campaign  not found ");
            }
            //sonra hepsini apide yakalayacağızb
            var vmModel = _mapper.Map<Campaign>(model);
            _unitfOfWork.Campaigns.Update(vmModel);
            if (_unitfOfWork.SaveChanges())//doğruysa true dön yanlışsa false
            {
                return true;
            }
            return false;

        }

        public CampaignQueryViewModel GetById(int id)
        {
            var campaign =_unitfOfWork.Campaigns.GetById(id);
            return _mapper.Map < CampaignQueryViewModel > (campaign);
        }

        public bool Delete( int id)//düzeltilecek
        {
            var campaign = _unitfOfWork.Campaigns.GetById(id);
            if (campaign is null)
            {
                throw new NotImplementedException("Campaign  not found ");
            }
            //sonra hepsini apide yakalayacağızb

            campaign.IsDeleted = true;//silmiyoruz ama silinmiş gösteriyoruz

            _unitfOfWork.Campaigns.Update(campaign);
          
            if (_unitfOfWork.SaveChanges())//doğruysa true dön yanlışsa false
            {
                return true;
            }
            return false;
        }
    }
}
