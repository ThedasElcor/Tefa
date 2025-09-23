using Tefa.Domain.Entities.Ao3Connections;
using Tefa.Domain.Entities.Community;
using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.Relationships
{
    public class RelationshipInstance
    {
        public required int Id { get; set; }
        public required int RelationshipId { get; set; }
        public required Relationship Relationship { get; set; }
        public required ICollection<Character> Characters { get; set; } = [];
        public ICollection<CharacterInstance> CharacterInstances { get; set; } = [];
        public string? MetadataKey { get; set; }
        public string? MetadataJson { get; set; }

        // Navigation properties
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
        public ICollection<FanWork> FanWorks { get; set; } = [];
    }
}
