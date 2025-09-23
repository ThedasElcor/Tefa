using Tefa.Domain.Entities.Community;
using Tefa.Domain.Entities.FandomCore.ConLangs;
using Tefa.Domain.Entities.FandomCore.Groups;
using Tefa.Domain.Entities.FandomCore.Locations;
using Tefa.Domain.Entities.FandomCore.Species;
using Tefa.Domain.Entities.MetadataCore.Fandoms;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.Characters
{
    public class CharacterInstance
    {
         /// <summary>
        /// Represents a mutable, contextualized version of a Character, created per use (e.g., in a fanwork or request).
        /// </summary>
        /// <remarks>
        /// Character variants should not be confused with character instances.
        /// A Variant is a logical, canonical, semi-canonical, or popular fanon version. 
        /// An Instance is a specific, customisable character for a request, offer, fanwork, etc.
        ///  Instances allow for personalization (e.g., AU traits, gender identity, background) without altering the underlying variant.
        /// </remarks>
        /// <example>
        /// "The Warden" (Dragon Age) has canonical variants like "Female Warden" "Female Dwarf Noble Warden" and fanon variants for Non-Binary Wardens
        /// "The Doctor" (Dr. Who) has the variants "Third Doctor", "Tenth Doctor"
        /// An instance of Kaidan Alenko (Mass Effect) could be a trans masc character from East Texas in a cowboys AU I just made up
        /// </example>

        //Metadata
        public required int Id { get; set; }
        public ICollection<LanguageSlug> Languages { get; set; } = []; //What languages in this instance written in
        public FanWork? FanWork { get; set; } // Null for offers/requests, required for searchable entries

        //Instance of
        public required int CharacterId { get; set; }
        public required Character Character { get; set; }
        public ICollection<Fandom> InstanceFandoms { get; set; } = []; //Defaults and crossover additions
       
        // Character Information
        public string? InstanceName { get; set; } 
        public bool? HasMagic { get; set; } // Inc. magic, biotics, Force sensitivity, psionics, etc.
        public string? InstanceGenderName{ get; set; }
        public ICollection<GenderSysTag> InstanceGenderSysTags { get; set; } = []; // Parsing Tags
        public string? InstanceOrientationName { get; set; }
        public ICollection<OrientationSysTag> OrientationSysTags { get; set; } = []; // Parsing Tags
        public string? InstanceDisabilityName { get; set; }
        public ICollection<DisabilitySysTag> DisabilitySysTags { get; set; } = []; // Parsing Tags
        public ICollection<ConLang> KnownLanguages { get; set; } = [];
        public ICollection<SpeciesItem> Species { get; set; } = [];
        public ICollection<SpeciesSysTag> InstanceSpeciesSysTags { get; set; } = [];
        public ICollection<GroupInstance> AssociatedGroupInstances { get; set; } = [];
        public ICollection<LocationInstance> AssociatedLocationInstances { get; set; } = [];

        public string FreeformNotes {  get; set; } = string.Empty;
    }
}
