using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishnat_Yossef.Core.InterfaceRepository
{
    public interface IRepository<T>
    {
        public List<T> GetAll();
        public T Get(int id);
        public bool Add(T repository);
        public bool Update(int id,T repository);
        public bool Delete(int id);
    }
}
