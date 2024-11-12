using Microsoft.AspNetCore.Mvc;
using Mishnat.entities;
using Mishnat.NewFolder;

namespace Mishnat.Service
{
    public class UserService
    {
        TzValid tzValid = new TzValid();
        ErrorTZ errorTZ = new ErrorTZ();
        readonly IDataContext _dataContext;

        public UserService(IDataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        private static int id = 1;        
        #region Function
        public List<User> GetUsers() { return _dataContext.LoudUsers(); }
        public User GetUserById(int id)
        {
            var users= _dataContext.LoudUsers();
            if (users == null) { return null; }
            return users.Where(u => u.UserId==id).FirstOrDefault<User>();
        }
        public bool UpdateUserById(User user, int usteId)
        {
            var users = _dataContext.LoudUsers();
            if (users == null) { return false; }

            User u =users.Find(u => u.UserId==usteId);
            if (u == null) { return false; }

            tzValid.IsOk(user.Tz, out errorTZ);
            if(errorTZ!=ErrorTZ.OK)
                 return false;
            u.Tz = user.Tz;
            u.Address = user.Address;
            u.Email = user.Email;
            u.DateOfRegistration = user.DateOfRegistration;
            u.Email=user.Email;
            u.Name = user.Name;
            u.Phon=user.Phon;
            if(_dataContext.SaveUsers(users))
                return true;
            return false;
        }
        public bool AddUser(User user)
        {
            var users = _dataContext.LoudUsers();
            if (users ==null) { return false; }

            if (users.Exists(u => u.Tz.Equals(user.Tz))) { return false; }

            tzValid.IsOk(user.Tz, out errorTZ);
            if(errorTZ!=ErrorTZ.OK) return false;

            
            users.Add(user);
            if(_dataContext.SaveUsers(users))
                 return true;
            return false;
        }
        public bool DeleteUser(int id)
        {
            var users = _dataContext.LoudUsers();

            if (users == null) { return false; }
            User delUser = users.Find(u => u.UserId == id);
            if (delUser == null)
            {
                return false;
            }
            users.Remove(delUser);
            if (_dataContext.SaveUsers(users))
                return true;
            return false;
        }
        #endregion
    }
}
