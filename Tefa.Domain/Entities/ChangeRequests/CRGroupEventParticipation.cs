using Tefa.Domain.Entities.FandomCore.EventParticipants;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRGroupEventParticipation : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public GroupEP? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public GroupEPInstance? EntityInstance { get; set; }
    }
}
