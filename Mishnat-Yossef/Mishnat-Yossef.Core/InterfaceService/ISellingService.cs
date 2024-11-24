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
        public List<Selling> GetAll();
        public User Get(string id);
        public bool Add(Selling selling);
        public bool Update(string id, Selling selling);
        public bool Delete(string id);
    }
}
