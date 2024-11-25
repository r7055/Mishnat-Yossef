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
    public class UserRepository : IRepository<User>
    {
        readonly IdataContext _idataContext;
        public UserRepository(IdataContext _idataContext)
        {
            _idataContext = _idataContext;
        }
        public bool Add(User user)
        {
           _idataContext.Users.Add(user);
            return _idataContext.SaveDada<User>(_idataContext.Users);
        }
        public bool Delete(string id)
        {
            return _idataContext.Users.Remove(_idataContext.Users.Find((user)=>user.UserId==id))&&
            _idataContext.SaveDada(_idataContext.Users);
        }
        public User Get(string id)
        {
           return _idataContext.Users.Find(user=>user.UserId==id);
        }
        public List<User> GetAll()
        {
           return _idataContext.Users;
        }
        public bool Update(string id, User user)
        {
            User u=_idataContext.Users.Find(user=>user.UserId==id);
            if (u!=null)
            {
                u.Tz = user.Tz;
                u.Address = user.Address;
                u.Email = user.Email;
                u.DateOfRegistration = user.DateOfRegistration;
                u.Email = user.Email;
                u.Name = user.Name;
                u.Phon = user.Phon;
                return _idataContext.SaveDada(_idataContext.Users);
            }
            return false;
        }
    }
}
