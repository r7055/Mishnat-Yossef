//using Mishnat_Yossef.Core.Entities;
//using Mishnat_Yossef.Core.InterfaceRepository;
//using Mishnat_Yossef.Core.InterfaceService;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Mishnat_Yossef.Data.Repository
//{
//    public class SellingRepositoty : IRepository<Selling>
//    {
//        readonly DataContext _dataContext;
//        public SellingRepositoty(DataContext idataContext)
//        {
//            _dataContext = idataContext;
//        }
//        public bool Add(Selling selling)
//        {
//            try
//            {
//                _dataContext.Sellings.Add(selling);
//                _dataContext.SaveChanges();
//                return true;
//            }
//            catch (Exception ex)
//            {
//                return false;
//            }
//        }
//        public bool Delete(int id)
//        {
//            try
//            {
//                _dataContext.Sellings.Remove(Get(id));
//                _dataContext.SaveChanges();
//                return true;
//            }
//            catch (Exception ex)
//            {
//                return false;
//            }
//        }
//        public Selling Get(int id)
//        {
//            return _dataContext.Sellings.Find(id);
//        }
//        public List<Selling> GetAll()
//        {
//            return _dataContext.Sellings.ToList();
//        }
//        public bool Update(int id, Selling selling)
//        {
//            Selling s = _dataContext.Sellings.Find(id);
//            if (s == null) return false; try
//            {
//                s.Parasha = selling.Parasha == null ? s.Parasha : selling.Parasha;
//                s.Products = selling.Products == null ? s.Products : selling.Products;
//                s.Date = s.Date == null ? s.Date : selling.Date;
//                _dataContext.SaveChanges();
//                return true;
//            }
//            catch (Exception ex)
//            {
//                return false;
//            }

//        }
//    }
//}
