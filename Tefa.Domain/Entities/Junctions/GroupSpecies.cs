using Tefa.Domain.Entities.Groups;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Entities.Species;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Junctions
{
    public class GroupSpecies
    {
        public required int Id { get; set; }
        public required int GroupId { get; set; }
        public required Group Group { get; set; }
        public required int SpeciesId { get; set; }
        public required SpeciesItem Species {  get; set; }
        public ICollection<AffiliationType> AffiliationTypes { get; set; } = [];
        public ICollection<Nuance> NuanceNotes { get; set; } = [];
    }
}
