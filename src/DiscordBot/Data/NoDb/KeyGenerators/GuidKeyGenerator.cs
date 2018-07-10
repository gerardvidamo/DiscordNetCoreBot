using System;
using System.Collections.Generic;
using System.Text;
using DiscordBot.Interfaces;

namespace DiscordBot.Data.NoDb.KeyGenerators
{
    public class GuidKeyGenerator : IKeyGenerator
    {
        public virtual string GenerateKey(object key)
        {
            if(!string.IsNullOrEmpty(key.ToString()) && key.ToString().Length == 36)
            {
                return key.ToString();
            }

            return Guid.NewGuid().ToString();
        }
    }
}
