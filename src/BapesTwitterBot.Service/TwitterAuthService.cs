using System.Diagnostics;
using System.Threading.Tasks;
using BapesTwitterBot.Domain;
using BapesTwitterBot.Domain.Models;
using Tweetinvi;
using Tweetinvi.Models;

namespace BapesTwitterBot.Service
{
    public class TwitterAuthService
    {
        private readonly BapesTwitterBotContext _context;
        private readonly IAuthenticationContext _authenticationContext;

        public TwitterAuthService(BapesTwitterBotContext context, TwitterAppSettings appSettings)
        {
            _context = context;

            var appCredentials = new TwitterCredentials(appSettings.Key, appSettings.Secret);

            _authenticationContext = AuthFlow.InitAuthentication(appCredentials);
        }

        public string GetAuthUrl()
        {
            return _authenticationContext.AuthorizationURL;
        }

        public void AddUser(string username, string pin)
        {
            var userCredentials = AuthFlow.CreateCredentialsFromVerifierCode(pin, _authenticationContext);

            _context.TwitterUsers.Add(new TwitterUser
            {
                Username = username,
                AccessToken = userCredentials.AccessToken,
                AccessTokenSecret = userCredentials.AccessTokenSecret
            });

            _context.SaveChanges();
        }
    }
}