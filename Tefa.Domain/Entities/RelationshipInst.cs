using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community;
using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities
{
    /* Unlike with the other entities, there can be no canon lock on relationships. 
     * Essentially, a relationship will need to be possible with any Character already in the system.
     * From there, we can set up a system for creating characters from currently unsupported fandoms to fit.
     * It could work on the change request system but would need to create at least some sort of entity 
     * without approval for relationship instantiation to work.*/
    public class RelationshipInst : Instance
    {
        public required int RelationshipId { get; set; } 
        public required Relationship Relationship { get; set; }
        public ICollection<CharacterInst> Characters { get; set; } = [];
    }
}
