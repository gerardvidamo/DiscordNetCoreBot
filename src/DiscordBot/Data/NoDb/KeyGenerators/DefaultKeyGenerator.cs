using System;
using System.Collections.Generic;
using System.Text;
using DiscordBot.Interfaces;

namespace DiscordBot.Data.NoDb.KeyGenerators
{
    public class DefaultKeyGenerator : GuidKeyGenerator, IKeyGenerator
    {
        public override string GenerateKey(object key)
        {
            if(!string.IsNullOrWhiteSpace(key.ToString()))
            {
                return key.ToString();
            }

            return base.GenerateKey(key);
        }
    }
}
