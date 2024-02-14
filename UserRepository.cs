using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Assignment
{

    public class UserChanged
    {

        public User user;
        public string action;

        public UserChanged(User user, string action)
        {
            this.user = user;
            this.action = action;
        }
    }
    public class UserRepository

    {
        public event Action<UserChanged> OnUserChanged;

        private List<User> users=new List<User>();

        public IEnumerable<User> GetUsers()
        {
            return users;
        }

        public void AddUser(User user)
        {
            users.Add(user);
            OnUserChanged?.Invoke(new UserChanged(user, "added"));
        }
        public void UpdateUser(User user)
        {
            int index = users.FindIndex(x => x.Id == user.Id);
            if (index == -1)
            {
                Console.WriteLine("User does not exist");
            }
            else {

                users[index] = user;
                OnUserChanged?.Invoke( new UserChanged(user, "updated"));
            }



        }

        public void DeleteUser(int id)
        {
            User user=users.Find(x=> x.Id == id);
            if (user != null)
            {
                users.Remove(user);
                OnUserChanged?.Invoke( new UserChanged(user, "deleted"));
            }
            else
            {
                Console.WriteLine("User does not exist");
            }


        }
    }
}
