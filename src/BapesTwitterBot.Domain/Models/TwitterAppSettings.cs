using System;
using System.Collections.Generic;
using System.Text;

namespace BapesTwitterBot.Domain.Models
{
    public class TwitterAppSettings
    {
        public TwitterAppSettings(string key, string secret)
        {
            Key = key;
            Secret = secret;
        }

        public string Key { get; set; }

        public string Secret { get; set; }

    }
}
