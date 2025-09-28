using Tefa.Domain.CognitiveLoadJail.Entities;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.ChangeRequests
{
    public class CRGroupEventParticipation : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public GroupEP? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public GroupEPInstance? EntityInstance { get; set; }
    }
}
