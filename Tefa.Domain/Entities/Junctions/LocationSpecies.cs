using Tefa.Domain.Entities.Locations;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Entities.Species;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Junctions
{
    public class LocationSpecies
    {
        public required int Id { get; set; }
        public required int LocationId { get; set; }
        public required Location Location { get; set; }
        public required SpeciesItem Species {  get; set; }
        public ICollection<AffiliationType> AffiliationTypes { get; set; } = [];
        public ICollection<Nuance> NuanceNotes { get; set; } = [];
    }
}
