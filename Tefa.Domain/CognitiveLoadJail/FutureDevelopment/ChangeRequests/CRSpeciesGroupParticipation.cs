using Tefa.Domain.Entities.Junctions;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.ChangeRequests
{
    public class CRSpeciesGroupParticipation : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public SpeciesGroup? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public SpeciesGroupInst? EntityInstance { get; set; }
    }
}
