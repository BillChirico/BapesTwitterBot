
 using System;
 using BapesTwitterBot.Domain;
 using BapesTwitterBot.Service;

namespace BapesTwitterBot.Console
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Auth();
        }

        private static void Auth()
        {
            var authService = new TwitterAuthService(new BapesTwitterBotContext());

            System.Console.WriteLine($"Auth URL: {authService.GetAuthUrl()}");

            System.Console.WriteLine("Twitter Username:");
            var username = System.Console.ReadLine();

            System.Console.WriteLine("PIN:");
            var pin = System.Console.ReadLine();

            authService.AddUser(username, pin);

            System.Console.WriteLine("Added");
        }
    }
}