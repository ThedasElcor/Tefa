using Tefa.Domain.Entities.Community;
using Tefa.Domain.Entities.FandomCore.GroupParticipants;
using Tefa.Domain.Entities.FandomCore.LocationAssociations;
using Tefa.Domain.Entities.MetadataCore.Ao3Tags;
using Tefa.Domain.Entities.MetadataCore.Fandoms;
using Tefa.Domain.Entities.MetadataCore.MediaAppearances;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.Characters
{
    /// <summary>
    /// Represents a character, or a possible character variant in the system.
    /// </summary>
    /// <remarks>
    /// Character variants should not be confused with character instances.
    /// A Variant is a logical, canonical, semi-canonical, or popular fanon version. 
    /// An Instance is a specific, customisable character for a request, offer, fanwork, etc.
    /// Instances allow for personalization (e.g., AU traits, gender identity, background) without altering the underlying variant.
    /// </remarks>
    /// <example>
    /// "The Warden" (Dragon Age) has canonical variants like "Female Warden" "Female Dwarf Noble Warden" and fanon variants for Non-Binary Wardens
    /// "The Doctor" (Dr. Who) has the variants "Third Doctor", "Tenth Doctor"
    /// An instance of Kaidan Alenko (Mass Effect) could be a trans masc character from East Texas in a cowboys AU I just made up
    /// </example>
    public class Character
    {
        //Metadata
        public required int Id { get; set; }
        public FandomId? PrimaryFandom { get; set; }
        public ICollection<Fandom> Fandoms { get; set; } = [];
        public ICollection<CharacterMA> CharacterAppearances { get; set; } = [];
        public string? SysName { get; set; } //For administrative convenience, use Names to support localization and variants

        //Character Information
        public ICollection<CharacterName> Names { get; set; } = [];
        public bool? HasMagic { get; set; } // Inc. magic, biotics, Force sensitivity, psionics, etc.
        public ICollection<GenderName> GenderNames { get; set; } = []; // Freeform, localizable text
        public ICollection<GenderSysTag> GenderSysTags { get; set; } = []; // Parsing Tags
        public ICollection<OrientationName> OrientationNames { get; set; } = []; // Freeform, localizable text
        public ICollection<OrientationSysTag> OrientationSysTags { get; set; } = []; // Parsing Tags
        public ICollection<DisabilityName> DisabilityNames { get; set; } = []; // Freeform, localizable text
        public ICollection<DisabilitySysTag> DisabilitySysTags { get; set; } = []; // Parsing Tags
        public ICollection<CharacterConlang> KnownLanguages { get; set; } = [];
        public ICollection<CharacterSpecies> Species { get; set; } = [];
        public ICollection<CharacterGP> Affiliations { get; set; } = [];
        public ICollection<CharacterLA> AssociatedLocations { get; set; } = [];     

        //Variant System (DAG)
        public bool IsCanonicalVariant { get; set; } = false;
        public int? RootVariantId { get; set; }
        public Character? RootVariant { get; set; }
        public ICollection<CharacterVariantLink> VariantOf { get; set; } = [];
        public ICollection<CharacterVariantLink> Variants { get; set; } = []; 
        public ICollection<Character> ConfirmedDistinctFrom { get; set; } = []; //For uniqueness verification utility

        // Fandom Appearances
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
        public ICollection<CharacterInstance> CharacterInstances { get; set; } = [];
        public ICollection<FanWork> FanWorks { get; set; } = [];
    }
}
