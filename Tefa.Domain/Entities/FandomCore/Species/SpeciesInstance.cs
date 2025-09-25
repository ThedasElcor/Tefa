using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.Species
{
    public class SpeciesInstance : Instance
    {
        public ICollection<SpeciesSysTag> InstanceSpeciesSysTags { get; set; } = [];
    }
}
