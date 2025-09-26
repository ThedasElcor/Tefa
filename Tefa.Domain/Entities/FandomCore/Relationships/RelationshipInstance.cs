using Tefa.Domain.Entities.Community;
using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.Relationships
{
    /* Unlike with the other entities, there can be no canon lock on relationships. 
     * Essentially, a relationship will need to be possible with any Character already in the system.
     * From there, we can set up a system for creating characters from currently unsupported fandoms to fit.
     * It could work on the change request system but would need to create at least some sort of entity 
     * without approval for relationship instantiation to work.*/
    public class RelationshipInstance : Instance
    {
        public required int RelationshipId { get; set; } 
        public required Relationship Relationship { get; set; }
        public ICollection<CharacterInstance> Characters { get; set; } = [];
        public ICollection<FanWork> FanWorks { get; set; } = [];
    }
}
