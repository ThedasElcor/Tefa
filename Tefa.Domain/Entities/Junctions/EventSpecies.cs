
using Tefa.Domain.Entities.Events;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Entities.Species;

namespace Tefa.Domain.Entities.Junctions
{
 public class EventSpecies
    {
        public required int Id { get; set; }
        public required int EventId { get; set; }
        public required Event Event { get; set; }
        public required int SpeciesId { get; set; }
        public required SpeciesItem Species {  get; set; }
        public ICollection<Nuance> NuanceNotes { get; set; } = [];
    }
}
