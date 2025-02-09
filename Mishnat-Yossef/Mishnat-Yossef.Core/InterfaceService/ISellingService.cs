using Mishnat_Yossef.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishnat_Yossef.Core.InterfaceService
{
    public interface ISellingService
    {
        public IEnumerable<Selling> GetAll();
        public Selling Get(int id);
        public bool Add(Selling selling);
        public bool Update(int id, Selling selling);
        public bool Delete(int id);
    }
}
