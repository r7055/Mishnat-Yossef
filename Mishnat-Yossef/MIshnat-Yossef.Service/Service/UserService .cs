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
    public class UserServicse : IUserService
    {
        readonly IRepositoryManager _repositoryManager;
        public UserServicse(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public bool Add(User user)
        {
            if (user == null) { return false; }
           return _repositoryManager._userRepository.Add(user);
        }

        public bool Delete(int id)
        {
           if(id == null) { return false; }
           return _repositoryManager._userRepository.Delete(id);
        }

        public User Get(int id)
        {
            return _repositoryManager._userRepository.Get(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _repositoryManager._userRepository.GetAll();
        }

        public bool Update(int id, User user)
        {
           if(user == null) { return false; }
           return (_repositoryManager._userRepository.Update(id, user));
        }
    }


}
