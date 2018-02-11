using BapesTwitterBot.Domain;
using BapesTwitterBot.Domain.Models;
using Tweetinvi;

namespace BapesTwitterBot.Service
{
    public class TwitterService
    {
        private readonly BapesTwitterBotContext _context;
        private readonly TwitterUser _user;
        private readonly TwitterAppSettings _appSettings;

        public TwitterService(BapesTwitterBotContext context, TwitterUser user, TwitterAppSettings appSettings)
        {
            _context = context;
            _user = user;
            _appSettings = appSettings;

            Login();
        }

        private void Login()
        {
            Auth.SetUserCredentials(_appSettings.Key, _appSettings.Secret, _user.AccessToken, _user.AccessTokenSecret);
        }
    }
}