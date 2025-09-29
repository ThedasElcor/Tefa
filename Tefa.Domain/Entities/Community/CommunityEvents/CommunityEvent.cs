using Tefa.Domain.Entities.Tags;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Community.CommunityEvents
{
    public class CommunityEvent
    {
        public required int Id { get; set; }
        public required int CommunityId { get; set; } 
        public Community? Community { get; set; } // Will be needed for hosted events, but not archiving
        public FandomEventType EventType { get; set; }
        public ICollection<CommunityEventName> Names { get; set; } = [];
        public ICollection<CommunityEventDescription> CommunityEventDescriptions { get; set; } = [];
        public ICollection<CommunityEventLink> EventLinks { get; set; } = [];

        // Navigation properties
        public ICollection<FandomTag> Fandoms { get; set; } = [];
        public ICollection<CommunityEventInstance> CommunityEventInstances { get; set; } = [];

    }
}
