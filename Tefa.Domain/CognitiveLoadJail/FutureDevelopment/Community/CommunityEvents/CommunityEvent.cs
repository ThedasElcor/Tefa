using Tefa.Domain.CognitiveLoadJail.Entities;
using Tefa.Domain.CognitiveLoadJail.Enums.Community;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community.CommunityEvents
{
    public class CommunityEvent
    {
        public required int Id { get; set; }
        public required int CommunityId { get; set; } 
        public required Community Community { get; set; }
        public FandomEventType EventType { get; set; }
        public ICollection<CommunityEventName> Names { get; set; } = [];
        public ICollection<CommunityEventDescription> CommunityEventDescriptions { get; set; } = [];
        public ICollection<CommunityEventLink> EventLinks { get; set; } = [];

        // Navigation properties
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
        public ICollection<Fandom> Fandoms { get; set; } = [];
        public ICollection<CommunityEventInstance> CommunityEventInstances { get; set; } = [];

    }
}
