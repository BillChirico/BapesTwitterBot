 using BapesTwitterBot.Domain;
 using BapesTwitterBot.Domain.Models;
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
            var appSettings = new TwitterAppSettings("CONSUMER_KEY", "CONSUMER_SECRET");

            var authService = new TwitterAuthService(new BapesTwitterBotContext(), appSettings);

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