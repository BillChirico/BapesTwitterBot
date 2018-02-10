using BapesTwitterBot.Domain;
using BapesTwitterBot.Domain.Models;
using Tweetinvi;

namespace BapesTwitterBot.Service
{
    public class TwitterService
    {
        private const string ConsumerKey = "";
        private const string ConsumerSecret = "";

        private readonly BapesTwitterBotContext _context;
        private readonly TwitterUser _user;

        public TwitterService(BapesTwitterBotContext context, TwitterUser user)
        {
            _context = context;
            _user = user;

            Login();
        }

        private void Login()
        {
            Auth.SetUserCredentials(ConsumerKey, ConsumerSecret, _user.AccessToken, _user.AccessTokenSecret);
        }
    }
}