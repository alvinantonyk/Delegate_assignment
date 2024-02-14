using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Assignment
{
    public class SMSNotificationService : INotificationService
    {
        public void Notify(string message) 
        {
            Console.WriteLine("SMS "+message);
        }
    }

    public class EmailNotificationService : INotificationService
    {
        public void Notify(string message)
        {
            Console.WriteLine("email "+message);
        }
    }

    public class PushNotificationService : INotificationService
    {
        public void Notify(string message)
        {
            Console.WriteLine("push "+message);
        }
    }

}
