using Tefa.Domain.Entities.FandomCore.Species;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.Characters
{
    public class CharacterSpeciesInstance : Instance
    {
        public required int CharacterId { get; set; }
        public required Character Character { get; set; }
        public required int SpeciesId { get; set; }
        public required SpeciesInstance Species { get; set; }
        public ICollection<SpeciesSysTag> SpeciesTags { get; set; } = [];
        public ICollection<AffiliationType> AffiliationTypes { get; set; } = [];
    }
}
