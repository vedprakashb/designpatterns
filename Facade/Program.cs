using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var user = new User
            {
                UserId = 100,
                UserName = "Ved"
            };
            new UserRegistration().RegisterUser(user);
        }
    }
}
