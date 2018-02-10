namespace BapesTwitterBot.Domain.Models
{
    public class TwitterUser
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string AccessToken { get; set; }

        public string AccessTokenSecret { get; set; }
    }
}