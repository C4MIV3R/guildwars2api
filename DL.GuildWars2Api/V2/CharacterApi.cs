using System.Threading.Tasks;
using DL.GuildWars2Api.Contracts.V2;
using DL.GuildWars2Api.Models.V2;

namespace DL.GuildWars2Api.V2
{
    internal class CharacterApi : AuthenticatedBase, IAuthenticatedCharacterApi
    {
        public CharacterApi(string key)
            : base(key)
        {
        }

        public async Task<string[]> GetCharactersAsync()
        {
            this.EnsureApiKey();
            const string url = "v2/characters";
            return await new HttpClientHelper().GetStringAsync<string[]>(url, this.Key);
        }

        public async Task<Character> GetCharacterAsync(string characterName)
        {
            this.EnsureApiKey();
            var name = characterName.Replace(" ", "%20");
            var url = $"v2/characters/{name}";
            return await new HttpClientHelper().GetStringAsync<Character>(url, this.Key);
        }
    }
}
