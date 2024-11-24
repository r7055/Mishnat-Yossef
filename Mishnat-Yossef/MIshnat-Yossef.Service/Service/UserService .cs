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
        readonly IRepository<IUserService> _userRepository;
        public bool Add(User user)
        {
            _userRepository.Add(user);
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public User Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(string id, User user)
        {
            throw new NotImplementedException();
        }
    }


}
