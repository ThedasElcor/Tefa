using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.Relationships
{
    public class RelationshipInstance : Instance
    {
        public required int RelationshipId { get; set; }
        public required Relationship Relationship { get; set; }
        public required ICollection<Character> Characters { get; set; } = [];
        public ICollection<CharacterInstance> CharacterInstances { get; set; } = [];
    }
}
