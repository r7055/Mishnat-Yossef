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
        public SellingRepositoty(IdataContext idataContext)
        {
            _dataContext = idataContext;
        }
        public bool Add(Selling selling)
        {
            _dataContext.Sellings.Add(selling);
            return _dataContext.SaveDada(_dataContext.Sellings);
        }
        public bool Delete(string id)
        {
            return _dataContext.Sellings.Remove(_dataContext.Sellings.Find(s => s.SellingId == id)) &&
                _dataContext.SaveDada(_dataContext.Sellings);
        }
        public Selling Get(string id)
        {
            return _dataContext.Sellings.Find(s => s.SellingId == id);
        }
        public List<Selling> GetAll()
        {
            return _dataContext.Sellings;
        }
        public bool Update(string id, Selling selling)
        {
            Selling s=_dataContext.Sellings.Find(s=>s.SellingId==id);
            if (s!=null)
            {
                s.Parasha = selling.Parasha;
                s.Products = selling.Products;
                s.Date = s.Date;
                return _dataContext.SaveDada(_dataContext.Sellings);
            }
            return false;
        }
    }
}
