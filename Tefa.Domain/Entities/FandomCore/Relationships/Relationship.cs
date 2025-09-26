using Tefa.Domain.Entities.Community;
using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Entities.MetadataCore.Ao3Tags;
using Tefa.Domain.Entities.MetadataCore.Fandoms;
using Tefa.Domain.Entities.MetadataCore.MediaAppearances;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.Relationships
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
        public bool IsGen { get; set; } // Whether this relationship is gen (no romantic/sexual elements)
        public bool IsMulti { get; set; } // Whether this relationship involves more than two characters
        
        // Navigation properties
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
        public ICollection<Character> Characters { get; set; } = [];
        public ICollection<Fandom> Fandoms { get; set; } = [];
        public ICollection<RelationshipMA> MediaAppearances { get; set; } = [];
        public ICollection<FanWork> FanWorks { get; set; } = [];

        //For relationships including characters with multiple canon variants like Shepard or The Doctor
        public Relationship? RootVariant { get; set; }
        public ICollection<RelationshipVariantLink> VariantOf { get; set; } = [];
        public ICollection<RelationshipVariantLink> Variants { get; set; } = [];
    }
}
