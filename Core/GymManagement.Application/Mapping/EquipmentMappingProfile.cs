using AutoMapper;
using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Mapping
{
   public class EquipmentMappingProfile:Profile
    {
        public EquipmentMappingProfile()
        {
            CreateMap<Equipment, EquipmentMappingProfile>().ReverseMap();
        }
    }
}
