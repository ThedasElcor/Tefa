using Tefa.Domain.Entities.Junctions;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRSpeciesEventParticipation : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public SpeciesEvent? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public SpeciesEventInst? EntityInstance { get; set; }
    }
}
