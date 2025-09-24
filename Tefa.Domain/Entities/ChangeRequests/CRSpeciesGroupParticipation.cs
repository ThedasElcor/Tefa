using Tefa.Domain.Entities.FandomCore.GroupParticipants;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRSpeciesGroupParticipation : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public SpeciesGP? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public SpeciesGPInstance? EntityInstance { get; set; }
    }
}
