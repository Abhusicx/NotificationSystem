
using System.Runtime.CompilerServices;
using EmployeeNotificationSystem;

namespace EmployeeNotificationSystem
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("for abhijeet");
            NotificationthroughClass Abhijeet = getNotification("Email");
            Abhijeet.Notificationtype("Abhijeet");
            Abhijeet.EventReminder();
            Abhijeet.SystemAlert();
            Abhijeet.NewPolicyAnnouncement();
            Console.WriteLine();

            Console.WriteLine("for parth");
            NotificationthroughClass Parth = getNotification("SMS");
            Parth.Notificationtype("parth");
            Parth.EventReminder();
            Parth.SystemAlert();
            Parth.NewPolicyAnnouncement();
            Console.WriteLine();

            Console.WriteLine("for Chandragupt");
            NotificationthroughClass Chandragupt = getNotification("Push");
            Parth.Notificationtype("parth");
            Chandragupt.EventReminder();
            Chandragupt.SystemAlert();
            Chandragupt.NewPolicyAnnouncement();
        }

        private static NotificationthroughClass getNotification(string v)
        {
            if (v == "Email")
            {
                return new Email();
            }
            else if (v == "SMS")
            {
                return new SMS();
            }
            else if (v == "Push")
            {
                return new PushNotification();
            }
            else
            {
                return null;
            }
        }
    }
}
