using Tefa.Domain.Entities.Characters;
using Tefa.Domain.Entities.Community;
using Tefa.Domain.Entities.Fandoms;
using Tefa.Domain.Entities.Groups;
using Tefa.Domain.Entities.Locations;
using Tefa.Domain.Entities.Species;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Events
{  /// <summary>
   /// Represents a mutable, contextualized version of an Eventr, created per use (e.g., in a fanwork or request).
   /// </summary>
    public class EventInstance
    {
        //Metadata
        public required int Id { get; set; }
        public ICollection<LanguageSlug> Languages { get; set; } = []; //What languages in this instance written in
        public FanWork? FanWork { get; set; } // Null for offers/requests, required for searchable entries

        //Instance of
        public required int EventId { get; set; }
        public required Event Event { get; set; }
        public ICollection<Fandom> InstanceFandoms { get; set; } = []; //Defaults and crossover additions

        public string? InstanceName { get; set; }
        public ICollection<EventDescription> EventDescriptions { get; set; } = [];
        public ICollection<LocationInstance> AssociatedLocationInstances { get; set; } = [];
        public ICollection<CharacterInstance> AssociatedCharacterInstances { get; set; } = [];
        public ICollection<GroupInstance> AssociatedGroupInstances {  get; set; } = [];
        public ICollection<SpeciesItem> Species { get; set; } = [];
        public ICollection<SpeciesSysTag> InstanceSpeciesSysTags { get; set; } = [];
        
        public string FreeformNotes { get; set; } = string.Empty;
    }
}
