using Tefa.Domain.CognitiveLoadJail.Entities;
using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community;
using Tefa.Domain.Entities.Junctions;
using Tefa.Domain.Entities.Tags;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities
{
    public class Relationship
    {
        /* Unlike with the other entities, there can be no canon lock on relationships. 
        * Essentially, a relationship will need to be possible with any Character already in the system.
        * From there, we can set up a system for creating characters from currently unsupported fandoms to fit.
        * It could work on the change request system but would need to create at least some sort of entity 
         * without approval for relationship instantiation to work.*/
        public required int Id { get; set; }
        public bool? IsCanonical { get; set; } = false; // Whether this relationship is canonical in its source material
        public ICollection<RelationshipStructureTag> StructureTags { get; set; } = [];
        public ICollection<RomanticOrientationTag> RomanticOrientationTags { get; set; } = [];
        public ICollection<SexualOrientationTag> SexualOrientationTags { get; set; } = [];
        
        // Navigation properties
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
        public ICollection<Character> Characters { get; set; } = [];
        public ICollection<Fandom> Fandoms { get; set; } = [];
        public ICollection<RelationshipMedia> MediaAppearances { get; set; } = [];
        public ICollection<RelationshipInst> Instances { get; set; } = [];

        //For relationships including characters with multiple canon variants like Shepard or The Doctor
        public Relationship? RootVariant { get; set; }
        public ICollection<RelationshipVariantLink> VariantOf { get; set; } = [];
        public ICollection<RelationshipVariantLink> Variants { get; set; } = [];
    }
}
