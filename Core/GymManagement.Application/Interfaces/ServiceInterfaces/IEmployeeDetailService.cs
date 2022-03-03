﻿using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Interfaces.ServiceInterfaces
{
  public  interface IEmployeeDetailService
    {
       // List<EmployeeDetail> GetAll();//unitof alınca tüm repositorylari almış alıyoz??
        EmployeeDetail GetById(int id);
        bool Create(EmployeeDetail model);
        bool Update(EmployeeDetail model, int id);
        bool Delete(int id);
    }
}
