using Tefa.Domain.Entities.FandomCore.EventParticipants;
using Tefa.Domain.Entities.FandomCore.GroupParticipants;
using Tefa.Domain.Entities.FandomCore.LocationsAssociated;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.Events
{ 
    public class EventInstance : Instance
    {
        // Instance of
        public required int EventId { get; set; }
        public required Event Event { get; set; }

        // Instance Information
        public ICollection<EventLAInstance> AssociatedLocations { get; set; } = [];
        public ICollection<CharacterEPInstance> AssociatedCharacters { get; set; } = [];
        public ICollection<GroupEPInstance> AssociatedGroups {  get; set; } = [];
        public ICollection<SpeciesGPInstance> AssociatedSpecies { get; set; } = [];
        public ICollection<SpeciesSysTag> SpeciesSysTags { get; set; } = [];

    }
}
