using Tefa.Domain.Entities.Abstract;
using Tefa.Domain.Entities.Junctions;
using Tefa.Domain.Entities.Tags;


namespace Tefa.Domain.Entities
{
    public class CharacterInst : Instance
    {
        //Instance of
        public required int CharacterId { get; set; }
        public required Character Character { get; set; }
        public string? Name { get; set; }
       
        // Instance Information
        public bool? HasMagic { get; set; } // Inc. magic, biotics, Force sensitivity, psionics, etc.
        public ICollection<Condition> HasConditions { get; set; } = [];
        public ICollection<AdaptiveAid> UsesAids { get; set; } = [];

        public ICollection<GenderIdentityTag> GenderIdentity { get; set; } = [];
        public ICollection<GenderPresentationTag> GenderPresentation { get; set; } = [];
        public ICollection<RomanticOrientationTag> RomanticOrientation { get; set; } = [];
        public ICollection<SexualOrientationTag> SexualOrientation { get; set; } = [];
        public ICollection<RelationshipStructureTag> RelationshipStructurePreferences { get; set; } = [];
        public ICollection<SexAnatomyTag> SexAnatomy { get; set; } = [];

        public ICollection<CharacterLanguageInst> KnownLanguages { get; set; } = [];
        public ICollection<SpeciesInst> Species { get; set; } = [];
        public ICollection<CharacteGroupInst> AssociatedGroups { get; set; } = [];
        public ICollection<CharacterLocationInst> AssociatedLocations { get; set; } = [];
    }
}
