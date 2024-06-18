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
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private protected readonly AppDbContext _appDbContext;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public int Add(T entity)
        {
            _appDbContext.Add(entity);
            return _appDbContext.SaveChanges();
        }

        public int Delete(T entity)
        {
            _appDbContext.Remove(entity);
            return _appDbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            if(typeof(T) == typeof(Employee))
            {
                return (IEnumerable<T>) _appDbContext.Employees.Include(E => E.Department).AsNoTracking().ToList();
            }
            else
            {
                return _appDbContext.Set<T>().AsNoTracking().ToList();
            }
        }

        public T GetById(int id)
        {
            return _appDbContext.Find<T>(id);
        }

        public int Update(T entity)
        {
            _appDbContext.Update(entity);
            return _appDbContext.SaveChanges();
        }
    }
}
