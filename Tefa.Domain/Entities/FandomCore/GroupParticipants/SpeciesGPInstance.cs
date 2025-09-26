using Tefa.Domain.Entities.FandomCore.Groups;
using Tefa.Domain.Entities.FandomCore.Species;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.GroupParticipants
{
    public class SpeciesGPInstance : Instance
    {
        public required int SpeciesInstanceId { get; set; }
        public required SpeciesInstance Species {  get; set; }
        public required int GroupInstanceId { get; set; }
        public required GroupInstance Group { get; set; }
        public ICollection<AffiliationType> AffiliationTypes { get; set; } = [];
    }
}
