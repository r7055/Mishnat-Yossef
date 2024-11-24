using Mishnat_Yossef.Core.Entities;
using Mishnat_Yossef.Core.InterfaceRepository;
using Mishnat_Yossef.Core.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishnat_Yossef.Data.Repository
{
    internal class SellingRepositoty : IRepository<Selling>
    {
        readonly IdataContext _dataContext;
        public bool Add(Selling repository)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Selling Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<Selling> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(string id, Selling repository)
        {
            throw new NotImplementedException();
        }
    }
}
