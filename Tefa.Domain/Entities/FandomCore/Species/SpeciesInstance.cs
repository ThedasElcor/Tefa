using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.Species
{
    public class SpeciesInstance : Instance
    {
        public required int SpeciesId { get; set; }
        public required SpeciesInstance Species { get; set; }
        public ICollection<SpeciesSysTag> InstanceSpeciesSysTags { get; set; } = [];
    }
}
