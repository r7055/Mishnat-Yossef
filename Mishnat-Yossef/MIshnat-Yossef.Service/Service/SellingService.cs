using Mishnat_Yossef.Core.Entities;
using Mishnat_Yossef.Core.InterfaceRepository;
using Mishnat_Yossef.Core.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIshnat_Yossef.Service.Service
{
    public class SellingServicse : ISellingService
    {
        readonly IRepository<Selling> _SellingRepository;
        public SellingServicse(IRepository<Selling> repository)
        {
            _SellingRepository = repository;
        }
        public bool Add(Selling selling)
        {
           if (selling == null) { return false; }
           return _SellingRepository.Add(selling);
        }

        public bool Delete(int id)
        {
            if (id == null) return false;
            return _SellingRepository.Delete(id);
        }

        public Selling Get(int id)
        {
            return _SellingRepository.Get(id);
        }

        public List<Selling> GetAll()
        {
            return _SellingRepository.GetAll();
        }

        public bool Update(int id, Selling selling)
        {
           if(id == null) return false;
           return _SellingRepository.Update(id, selling);
        }
    }
}
