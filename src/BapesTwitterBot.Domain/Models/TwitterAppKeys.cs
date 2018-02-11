using System;
using System.Collections.Generic;
using System.Text;

namespace BapesTwitterBot.Domain.Models
{
    public class TwitterAppKeys
    {
        public TwitterAppKeys(string key, string secret)
        {
            Key = key;
            Secret = secret;
        }

        public string Key { get; set; }

        public string Secret { get; set; }

    }
}
