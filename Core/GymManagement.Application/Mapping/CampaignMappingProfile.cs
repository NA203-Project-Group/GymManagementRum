using AutoMapper;
using GymManagement.Application.ViewModels.CampaignViewModel;
using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Mapping
{
    //mapping nesneyi nesneye eşleme,classı class'a eşlme
  public  class CampaignMappingProfile:Profile
    {
        public CampaignMappingProfile()
        {
            CreateMap<Campaign, CampaignQueryViewModel>();//eşleme
            CreateMap<Campaign, CampaignQueryViewModel>();
        }
    }
}
