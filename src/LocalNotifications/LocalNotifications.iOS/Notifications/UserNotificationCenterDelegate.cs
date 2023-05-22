using System;
using UserNotifications;

namespace LocalNotifications.iOS.Notifications
{
    public class UserNotificationCenterDelegate : UNUserNotificationCenterDelegate
    {
        public UserNotificationCenterDelegate()
        {
        }

        public override void DidReceiveNotificationResponse(UNUserNotificationCenter center, UNNotificationResponse response,
            Action completionHandler)
        {
            Console.WriteLine("The user tapped the notification");
        }
    }
}
