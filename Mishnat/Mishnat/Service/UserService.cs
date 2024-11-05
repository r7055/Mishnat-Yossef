using Mishnat.NewFolder;

namespace Mishnat.Service
{
    public class UserService
    {
        public List<User> Users { get; set; }
        #region Function
        public List<User> GetUsers() { return Users; }
        public User GetUserById(string id)
        {
            if (Users == null) { return null; }
            return Users.Where(u => u.UserId.Equals(id)).FirstOrDefault<User>();
        }
        public bool UpdateUserById(User user, string usteId)
        {
            if (Users == null) { return false; }
            User u = Users.Find(u => u.UserId.Equals(usteId));
            if (u == null) { return false; }
            u = user;
            return true;
        }
        public bool AddUser(User user)
        {
            Users.Add(user);
            return true;
        }
        public bool DeleteUser(string id)
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
