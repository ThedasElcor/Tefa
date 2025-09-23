using Tefa.Domain.Entities.Ao3Connections;
using Tefa.Domain.Entities.Characters;
using Tefa.Domain.Entities.Community;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Relationships
{
    public class Relationship
    { 
        public required int Id { get; set; }
        public bool? IsCanonical { get; set; } = false; // Whether this relationship is canonical in its source material
        public bool IsGen { get; set; } // Whether this relationship is gen (no romantic/sexual elements)
        public bool IsMulti { get; set; } // Whether this relationship involves more than two characters
        public string? EligibilityMetadata { get; set; } //Json load of different eligibility criteria
        
        //System Tags
        public ICollection<GenderSysTag> GenderSysTags { get; set; } = [];
        public ICollection<SpeciesSysTag> SpeciesSysTags { get; set; } = [];
        public ICollection<DisabilitySysTag> DisabilitySysTags { get; set; } = [];

        // Navigation properties
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
        public ICollection<Character> Characters { get; set; } = [];
        public ICollection<Fandom> Fandoms { get; set; } = [];
        public ICollection<Media> Media { get; set; } = [];
        public ICollection<FanWork> FanWorks { get; set; } = [];

        //For relationships including characters with multiple canon variants like Shepard or The Doctor
        public Relationship? RootVariant { get; set; }
        public ICollection<RelationshipVariantLink> VariantOf { get; set; } = [];
        public ICollection<RelationshipVariantLink> Variants { get; set; } = [];
    }
}
