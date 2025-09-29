using Tefa.Domain.Entities.Community;
using Tefa.Domain.Entities.Junctions;
using Tefa.Domain.Entities.Metadata.MediaAppearances;
using Tefa.Domain.Entities.Tags;
using Tefa.Domain.Enums;


namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class Character
    {
        //Metadata
        public required int Id { get; set; }
        public Fandom? PrimaryFandom { get; set; }
        public ICollection<FandomTag> Fandoms { get; set; } = [];
        public ICollection<CharacterMedia> CharacterAppearances { get; set; } = [];
        public string? SysName { get; set; } //For administrative convenience, use Names to support localization and variants

        //Character Information
        public ICollection<CharacterName> Names { get; set; } = [];

        public bool? HasMagic { get; set; } // Inc. magic, biotics, Force sensitivity, psionics, etc.
        public ICollection<Condition> HasConditions { get; set; } = [];
        public ICollection<AdaptiveAid> UsesAids { get; set; } = [];
        
        public ICollection<GenderIdentityTag> GenderIdentity { get; set; } = [];
        public ICollection<GenderPresentationTag> GenderPresentation { get; set; } = [];
        public ICollection<AttractionTag> AttractionOrientation { get; set; } = [];
        public ICollection<RomanticOrientationTag> RomanticOrientation { get; set; } = [];
        public ICollection<SexualOrientationTag> SexualOrientation { get; set; } = [];
        public ICollection<RelationshipStructureTag> RelationshipStructurePreferences {  get; set; } = [];
        public ICollection<SexAnatomyTag> SexAnatomy { get; set; } = [];

        public ICollection<CharacterLanguage> KnowsLanguages { get; set; } = [];
        public ICollection<Species> Species { get; set; } = [];
        public ICollection<CharacterGroup> Affiliations { get; set; } = [];
        public ICollection<CharacterLocation> AssociatedLocations { get; set; } = [];
        public ICollection<CharacterNote> Notes { get; set; } = [];

        //Variant System (DAG)
        public bool IsCanonicalVariant { get; set; } = false;
        public int? RootVariantId { get; set; }
        public Character? RootVariant { get; set; }
        public ICollection<CharacterVariantLink> VariantOf { get; set; } = [];
        public ICollection<CharacterVariantLink> Variants { get; set; } = []; 
        public ICollection<Character> ConfirmedDistinctFrom { get; set; } = []; //For uniqueness verification utility

        // Fandom Appearances
        public ICollection<CharacterInst> CharacterInstances { get; set; } = [];
        public ICollection<FanWork> FanWorks { get; set; } = [];
    }
}
