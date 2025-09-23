using Tefa.Domain.Entities.Characters;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Entities.Species;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Junctions
{
    public class CharacterSpecies
    {
        public int Id { get; set; }
        public required int CharacterId { get; set; }
        public required Character Character { get; set; }
        public required int SpeciesId { get; set; }
        public required SpeciesItem Species {  get; set; }
        public ICollection<SpeciesSysTag> SpeciesTags { get; set; } = [];
        public ICollection<AffiliationType> AffiliationTypes { get; set; } = [];
        public ICollection<Nuance> NuanceNotes { get; set; } = [];
    }
}
