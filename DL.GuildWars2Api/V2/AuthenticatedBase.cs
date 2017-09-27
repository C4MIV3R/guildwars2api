using System;

namespace DL.GuildWars2Api.V2
{
    internal abstract class AuthenticatedBase
    {
        protected AuthenticatedBase(string key)
        {
            this.Key = key;
        }

        public string Key { get; set; }

        protected void EnsureApiKey()
        {
            this.EnsureApiKey(this.Key);
        }

        protected void EnsureApiKey(string keyToVerify)
        {
            if (!this.IsKeyValid(keyToVerify))
            {
                throw new InvalidOperationException("An API key must be set before calling this method.");
            }
        }

        protected bool IsKeyValid()
        {
            return this.IsKeyValid(this.Key);
        }

        protected bool IsKeyValid(string keyToVerify)
        {
            return !string.IsNullOrWhiteSpace(keyToVerify);
        }
    }
}
