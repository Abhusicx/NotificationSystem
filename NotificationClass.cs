using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNotificationSystem
{
    public abstract class NotificationthroughClass
    {
        public abstract void Notificationtype(string message);

        public NotificationthroughClass()
        {
        
            Console.WriteLine("welcome to our system");
        }

        public void NewPolicyAnnouncement()
        {
            
            Console.WriteLine("new policy has been announced!" );
        }

        public void EventReminder()
        {
            Console.WriteLine("New Event has been announced!");
        }

        public void SystemAlert()
        {
            Console.WriteLine("new Alert has been announced!");
        }
    }

    public class Email : NotificationthroughClass
    {
        public override void Notificationtype(string message)
        {
            Console.WriteLine("notification through email");
        }
    }

    public class SMS : NotificationthroughClass
    {
        public override void Notificationtype(string message)
        {
            Console.WriteLine("notification through SMS");
        }
    }

    public class PushNotification : NotificationthroughClass
    {
        public override void Notificationtype(string message)
        {
            Console.WriteLine("notification through PushNotification");
        }
    }
}
