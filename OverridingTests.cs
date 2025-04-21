using System;

namespace OverridingDemo
{
    public class Notification
    {
        public virtual void Send()
        {
            Console.WriteLine("Notification: Sending base notification.");
        }
    }

    public class EmailNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine("EmailNotification: Sending email notification (override).");
        }
    }

    public class SmsNotification : Notification
    {
        public new void Send()
        {
            Console.WriteLine("SmsNotification: Sending SMS notification (new).");
        }
    }

    public class PushNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine("PushNotification: Sending push notification (override).");
        }
    }

    public class InAppNotification : Notification
    {
        public new virtual void Send()
        {
            Console.WriteLine("InAppNotification: Sending in-app notification (new virtual).");
        }
    }

    public class CustomInAppNotification : InAppNotification
    {
        public override void Send()
        {
            Console.WriteLine("CustomInAppNotification: Custom in-app notification (override new virtual).");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Base Reference ---");
            Notification email = new EmailNotification();
            Notification sms = new SmsNotification();
            Notification push = new PushNotification();
            Notification inApp = new InAppNotification();
            Notification customInApp = new CustomInAppNotification();

            email.Send();         // override
            sms.Send();           // base method (new hides it)
            push.Send();          // override
            inApp.Send();         // base method (new hides it)
            customInApp.Send();   // base method (not overridden from Notification)

            Console.WriteLine("\n--- Derived Reference ---");
            SmsNotification smsD = new SmsNotification();
            InAppNotification inAppD = new InAppNotification();
            CustomInAppNotification customInAppD = new CustomInAppNotification();

            smsD.Send();              // new
            inAppD.Send();            // new virtual
            customInAppD.Send();      // override new virtual
        }
    }
}