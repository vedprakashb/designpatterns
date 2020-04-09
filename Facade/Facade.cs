using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    interface IRegistrationProcessor
    {
        void AddEntryToActiveDirectory();
        void SendWelcomeEmail();
        void NotifyToGenerateMemberidCard();
    }

    public class UserRegistration
    {
        public void RegisterUser(User user)
        {
            Console.WriteLine($"Registration process started .. for user {user.UserName}");
            RegistrationProcessor rp = new RegistrationProcessor();
            rp.AddEntryToActiveDirectory();
            rp.SendWelcomeEmail();
            rp.NotifyToGenerateMemberidCard();
            Console.WriteLine($"Registration process over .. for user {user.UserName}");

        }
    }


    public class RegistrationProcessor : IRegistrationProcessor
    {
        public void AddEntryToActiveDirectory()
        {
            Console.WriteLine("AddEntryToActiveDirectory called . entry made to ActiveDirectory to system1");
        }


        public void NotifyToGenerateMemberidCard()
        {
            Console.WriteLine("NotifyToGenerateMemberidCard called . Notified to generate MemberId Card to system2");

        }

        public void SendWelcomeEmail()
        {
            Console.WriteLine("SendWelcomeEmail called . Welcome email sent to user from system3");
        }
    }
    public class User
    {
        public String UserName { get; set; }
        public int UserId { get; set; }
    }
}
