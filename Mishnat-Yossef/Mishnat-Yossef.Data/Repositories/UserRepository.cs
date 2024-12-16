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
//    public class UserRepository : IRepository<User>
//    {
//        readonly DataContext _idataContext;
//        public UserRepository(DataContext idataContext)
//        {
//            _idataContext = idataContext;
//        }
//        public bool Add(User user)
//        {
//            try
//            {
//                _idataContext.Users.Add(user);
//                _idataContext.SaveChanges();
//                return true;
//            }
//            catch
//            {
//                return false;
//            }

//        }
//        public bool Delete(int id)
//        {
//            try
//            {
//                _idataContext.Users.Remove(Get(id));
//                _idataContext.SaveChanges();
//                return true;
//            }
//            catch
//            {
//                return false;
//            }
//        }
//        public User Get(int id)
//        {
//            return _idataContext.Users.Find(id);
//        }
//        public List<User> GetAll()
//        {
//            return _idataContext.Users.ToList();
//        }
//        public bool Update(int id, User user)
//        {
//            User u = _idataContext.Users.Find(id);
//            if (u == null) return false;
//            try
//            {
//                u.Tz = user.Tz == null ? u.Tz : user.Tz;
//                u.Address = user.Address == null ? u.Address : user.Address;
//                u.Email = user.Email == null ? u.Email : user.Email;
//                u.DateOfRegistration = user.DateOfRegistration == null ? u.DateOfRegistration : user.DateOfRegistration;
//                u.Name = user.Name == null ? u.Name : user.Name;
//                u.Phon = user.Phon == null ? u.Phon : user.Phon;
//                _idataContext.SaveChanges();
//                return true;
//            }
//            catch
//            {
//                return false;
//            }
//        }
//    }
//}
