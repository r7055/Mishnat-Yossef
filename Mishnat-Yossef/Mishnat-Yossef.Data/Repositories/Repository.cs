using Microsoft.EntityFrameworkCore;
using Mishnat_Yossef.Core.Entities;
using Mishnat_Yossef.Core.InterfaceRepository;
using Mishnat_Yossef.Core.InterfaceService;
using Mishnat_Yossef.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace mishnat_yossef.data.repository
{
    public class Repository<T>  : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        public Repository(DataContext context)
        {
            _dbSet = context.Set<T>();
        }
        public bool Add(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                //_dbSet.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                _dbSet.Remove(Get(id));
                //_dbSet.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public T Get(int id)
        {
            return _dbSet.Find(id);

        }
        public List<T> GetAll()
        {
            return _dbSet.ToList();

        }
        public bool Update(int id, T entity)
        {
            T e = _dbSet.Find(id);
            if (e == null) return false;
            try
            {
                PropertyInfo[] peoperties= typeof(T).GetProperties(); 
                foreach (PropertyInfo pr in peoperties)
                {
                    if (pr.CanWrite)
                    {
                        var value = pr.GetValue(entity);
                        if (value != null)
                        {
                            pr.SetValue(e, value);
                        }
                    }
                }
                //_dbSet.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
