using Tefa.Domain.Entities.FandomCore.EventParticipants;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRSpeciesEventParticipation : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public SpeciesEP? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public SpeciesEPInstance? EntityInstance { get; set; }
    }
}
