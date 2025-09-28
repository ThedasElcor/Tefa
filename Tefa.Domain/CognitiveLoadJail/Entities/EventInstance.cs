using Tefa.Domain.Entities.Abstract;
using Tefa.Domain.Entities.Junctions;
using Tefa.Domain.Enums;

namespace Tefa.Domain.CognitiveLoadJail.Entities
{ 
    public class EventInstance : Instance
    {
        // Instance of
        public required int EventId { get; set; }
        public required Event Event { get; set; }

        // Instance Information
        public ICollection<EventLocationInst> AssociatedLocations { get; set; } = [];
        public ICollection<CharacterEventInst> AssociatedCharacters { get; set; } = [];
        public ICollection<GroupEPInstance> AssociatedGroups {  get; set; } = [];
        public ICollection<SpeciesGroupInst> AssociatedSpecies { get; set; } = [];
        public ICollection<SpeciesSysTag> SpeciesSysTags { get; set; } = [];

    }
}
