using Tefa.Domain.Entities.Ao3Connections;
using Tefa.Domain.Entities.Community;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Events
{
    public class CommunityEvent
    {
        public required int Id { get; set; }
        public FandomEventType EventType { get; set; }
        public required string Name { get; set; }
        public string? Email { get; set; }
        public string? Description { get; set; }
        
        // Event Links
       public string? Links { get; set; } // JSON array of strings representing URLs

        // Navigation properties
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
        public ICollection<Fandom> Fandoms { get; set; } = [];
        public ICollection<CommunityEventInstance> FandomEventInstances { get; set; } = [];
        public ICollection<Collection> Collections { get; set; } = [];

    }
}
