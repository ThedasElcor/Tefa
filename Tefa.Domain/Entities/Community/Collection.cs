using Tefa.Domain.Entities.Events;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Community
{
    public class Collection
    {
        public required int Id { get; set; }
        public CommunityEventInstance? FandomEventInstance { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Url { get; set; }
  
        // Navigation properties
       public ICollection<Fandom> Fandoms { get; set; } = []; // Intended Collection Fandom(s), regardless of crossovers included
        public ICollection<Media> Media { get; set; } = []; // Intended Collection Media(s), regardless of crossovers included
        public ICollection<FanWork> FanWorks { get; set; } = [];
    }
}
