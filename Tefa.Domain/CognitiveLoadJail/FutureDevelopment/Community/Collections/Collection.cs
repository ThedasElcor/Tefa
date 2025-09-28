using Tefa.Domain.CognitiveLoadJail.Entities;
using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community;
using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community.CommunityEvents;
using Tefa.Domain.Entities;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community.Collections
{
    public class Collection
    {
        public required int Id { get; set; }
        public CommunityEventInstance? FandomEventInstance { get; set; }
        public ICollection<CollectionName> CollectionNames { get; set; } = [];
        public ICollection<CollectionLanguage> CollectionLanguages { get; set; } = [];
        public ICollection<CollectionDescription> CollectionDescriptions { get; set; } = [];
        public ICollection<CollectionLink> CollectionLinks { get; set; } = [];
  
        // Navigation properties
       public ICollection<Fandom> Fandoms { get; set; } = []; // Intended Collection Fandom(s), regardless of crossovers included
        public ICollection<Media> Media { get; set; } = []; // Intended Collection Media(s), regardless of crossovers included
        public ICollection<FanWork> FanWorks { get; set; } = [];
    }
}
