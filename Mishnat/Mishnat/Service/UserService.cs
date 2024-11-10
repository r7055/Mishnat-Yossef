using Microsoft.AspNetCore.Mvc;
using Mishnat.entities;
using Mishnat.NewFolder;

namespace Mishnat.Service
{
    public class UserService
    {
        TzValid tzValid = new TzValid();
        ErrorTZ errorTZ = new ErrorTZ();
        private static int id = 1;        
        #region Function
        public List<User> GetUsers() { return DataContextManager.Manager.Users; }
        public User GetUserById(int id)
        {
            if (DataContextManager.Manager.Users == null) { return null; }
            return DataContextManager.Manager.Users.Where(u => u.UserId==id).FirstOrDefault<User>();
        }
        public bool UpdateUserById(User user, int usteId)
        {
            if (DataContextManager.Manager.Users == null) { return false; }
            User u = DataContextManager.Manager.Users.Find(u => u.UserId==usteId);
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
            return true;
        }
        public bool AddUser(User user)
        {
            if(DataContextManager.Manager.Users ==null) { return false; }
            tzValid.IsOk(user.Tz, out errorTZ);
            if(errorTZ!=ErrorTZ.OK) return false;
            user.UserId = id++;
            DataContextManager.Manager.Users.Add(user);
            return true;
        }
        public bool DeleteUser(int id)
        {
            if(DataContextManager.Manager.Users == null) { return false; }
            User delUser = DataContextManager.Manager.Users.Find(u => u.UserId == id);
            if (delUser == null)
            {
                return false;
            }
            DataContextManager.Manager.Users.Remove(delUser);
            return true;
        }
        #endregion
    }
}
