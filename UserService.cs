using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Assignment
{
    public class UserService
    {
        private UserRepository userRepository=new UserRepository();
        private SMSNotificationService sMSNotificationService=new SMSNotificationService();
        private EmailNotificationService emailNotificationService=new EmailNotificationService();
        private PushNotificationService pushNotificationService=new PushNotificationService();

        public UserService() {

            userRepository.OnUserChanged += (userchanged) =>
            {
                User user = userchanged.user;
                string action = userchanged.action;
                sMSNotificationService.Notify($"User {action} - {user.Id}: {user.Name}");
                emailNotificationService.Notify($"User {action} - {user.Id}: {user.Name}");
                pushNotificationService.Notify($"User {action} - {user.Id}: {user.Name}");
                
            };
        }


        public IEnumerable<User> GetUsers()
        {
            return userRepository.GetUsers();
        }
        public void AddUser(User user)
        {
            userRepository.AddUser(user);
        }

        public void UpdateUser(User user)
        {
            userRepository.UpdateUser(user);
        }
        public void DeleteUser(int id)
        {
            userRepository.DeleteUser(id);

        }
    }
}
