using Demo.BLL.Interfaces;
using Demo.DAL.Data;
using Demo.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee> ,IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext dbcontext) : base(dbcontext)
        {
                
        }
        public IQueryable<Employee> GetEmployeeByAddress(string address)
        {
            return _appDbContext.Employees.Where(E => E.Address.ToLower().Contains(address.ToLower()));
        }
        public IQueryable<Employee> GetEmployeeByName(string name)
        {
            return _appDbContext.Employees.Include(E => E.Department).AsNoTracking().Where(E => E.Name.ToLower().Contains(name));
        }
    }
}
