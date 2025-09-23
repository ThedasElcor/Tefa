using Tefa.Domain.Entities.Ao3Connections;
using Tefa.Domain.Entities.Characters;
using Tefa.Domain.Entities.Community;
using Tefa.Domain.Entities.Locations;
using Tefa.Domain.Entities.Relationships;

namespace Tefa.Domain.Entities.Events
{
    public class Tagset
    {
        public required int Id { get; set; }
        public string? SysNotes { get; set; } // Internal notes about this tagset
        public string? Description { get; set; }

        //Tag Contents
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
        public ICollection<Relationship> Relationships { get; set; } = [];
        public bool AllowRelationships { get; set; } // Whether the tagset owner allows relationship matches
        public ICollection<Character> Characters { get; set; } = [];
        public bool AllowCharacters { get; set; } // Whether the tagset owner allows character matches
        public ICollection<Location> Locations { get; set; } = [];
        public bool AllowLocations { get; set; } // Whether the tagset owner allows location matches
        // Can expand to other match types in future

        // Navigation properties
        public ICollection<CommunityEventInstance> FandomEventInstances { get; set; } = [];
        public ICollection<Collection> Collections { get; set; } = [];
    }
}
