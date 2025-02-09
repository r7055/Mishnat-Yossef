using Mishnat_Yossef.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mishnat_Yossef.Core.InterfaceService
{
    public interface IUserService
    {
        public IEnumerable<User> GetAll();
        public User Get(int id);
        public bool Add(User user);
        public bool Update(int id, User user);
        public bool Delete(int id);
    }
}
