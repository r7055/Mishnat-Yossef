using Mishnat.NewFolder;

namespace Mishnat.Service
{
    public class UserService
    {
        public List<User> Users { get; set; }
        private static int id = 1;
        #region Function
        public List<User> GetUsers() { return Users; }
        public User GetUserById(int id)
        {
            if (Users == null) { return null; }
            return Users.Where(u => u.UserId==id).FirstOrDefault<User>();
        }
        public bool UpdateUserById(User user, int usteId)
        {
            if (Users == null) { return false; }
            User u = Users.Find(u => u.UserId==usteId);
            if (u == null) { return false; }
            u = user;
            return true;
        }
        public bool AddUser(User user)
        {
            if(Users == null) { return false; }
            user.UserId = id++;
            Users.Add(user);
            return true;
        }
        public bool DeleteUser(int id)
        {
            if(Users == null) { return false; }
            User delUser = Users.Find(u => u.UserId == id);
            if (delUser == null)
            {
                return false;
            }
            Users.Remove(delUser);
            return true;
        }
        #endregion
    }
}
