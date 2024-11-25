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
    internal class UserServicse : IUserService
    {
        readonly IRepository<User> _userRepository;
        public bool Add(User user)
        {
            if (user == null) { return false; }
           return _userRepository.Add(user);
        }

        public bool Delete(string id)
        {
           if(id == null) { return false; }
           return _userRepository.Delete(id);
        }

        public User Get(string id)
        {
            return _userRepository.Get(id);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public bool Update(string id, User user)
        {
           if(user == null) { return false; }
           return (_userRepository.Update(id, user));
        }
    }


}
