using Tefa.Domain.Entities.FandomCore.ConlangAssociations;
using Tefa.Domain.Entities.FandomCore.Conlangs;
using Tefa.Domain.Entities.FandomCore.GroupParticipants;
using Tefa.Domain.Entities.FandomCore.Groups;
using Tefa.Domain.Entities.FandomCore.Locations;
using Tefa.Domain.Entities.FandomCore.LocationsAssociated;
using Tefa.Domain.Entities.FandomCore.Species;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.Characters
{
    public class CharacterInstance : Instance
    {
        //Instance of
        public required int CharacterId { get; set; }
        public required Character Character { get; set; }
       
        // Instance Information
        public bool? HasMagic { get; set; } // Inc. magic, biotics, Force sensitivity, psionics, etc.
        public string? InstanceGenderName{ get; set; }
        public ICollection<GenderSysTag> InstanceGenderSysTags { get; set; } = []; // Parsing Tags
        public string? InstanceOrientationName { get; set; }
        public ICollection<OrientationSysTag> OrientationSysTags { get; set; } = []; // Parsing Tags
        public string? InstanceDisabilityName { get; set; }
        public ICollection<DisabilitySysTag> DisabilitySysTags { get; set; } = []; // Parsing Tags
        public ICollection<CharacterCAInstance> KnownLanguages { get; set; } = [];
        public ICollection<SpeciesInstance> Species { get; set; } = [];
        public ICollection<CharacterGPInstance> AssociatedGroups { get; set; } = [];
        public ICollection<CharacterLAInstance> AssociatedLocations { get; set; } = [];
    }
}
