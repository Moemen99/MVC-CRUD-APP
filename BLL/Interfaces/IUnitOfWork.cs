﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
         IDepartmentRepository Department { get; set; }
         IEmployeeRepository Employee { get; set; }

        int Complete();


    }
}
