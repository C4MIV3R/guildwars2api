# guildwars2api
C# wrapper for the official Guild Wars 2 API. This wrapper aims to wrap the calls to the GW2 API and the following conversion to POCOs. Any caching, patterns, etc. outside of that will be outside of this wrapper's scope. We want to create an easy to use and maintain wrapper that still allows for flexibility within your code.

[![guildwars2api MyGet Build Status](https://www.myget.org/BuildSource/Badge/guildwars2api?identifier=1896b9d8-a3ec-42dd-9f12-208831ec403c)](https://www.myget.org/)

### Implemented API Endpoints

| Version | Endpoint | Description |
|:-------:|:---------|:------------|
| 2 | account | Returns information about an account associated with an API key. |
| 2 | account/dungeons | Returns information about the current daily cleared dungeons associated with an API key. |
| 2 | account/raids | Returns information about completed raid events between weekly resets associated with an API key. |
| 2 | account/wallet | Returns information about wealth associated with an API key. |
| 2 | characters | Returns information on an account's characters. |
| 2 | currencies | Returns information about wallet currencies. |
| 2 | dungeons | Returns information about each dungeons and its associated paths. | 
| 2 | guild/:id | Returns core details about a given guild. |
| 2 | guild/:id/log | Returns information about a guild's event log. |
| 2 | guild/:id/members | Returns information about members of a guild. |
| 2 | guild/:id/ranks | Returns information about the permission ranks of a guild. |
| 2 | guild/:id/stash | Returns information about the contents of a guild's stash. |
| 2 | guild/:id/treasury | Returns information about a guild's treasury contents. |
| 2 | guild/permissions | Returns information about guild rank permissions. |
| 2 | guild/search | Returns information on guild ids to be used for other API queries. |
| 2 | guild/upgrades | Returns information about guild upgrades and scribe decorations. |
| 2 | items | Returns information about items |
| 2 | raids | Returns information about each raid and its associated events. |
| 2 | skins | Returns information about skins |
| 2 | tokeninfo | Returns information about the supplied API Key. |
| 2 | worlds | Returns world names |
| 1 | guild_details | Returns detailed information about a guild. |

### Useful Links

 - https://github.com/arenanet/api-cdi
 - https://wiki.guildwars2.com/wiki/API:Main
