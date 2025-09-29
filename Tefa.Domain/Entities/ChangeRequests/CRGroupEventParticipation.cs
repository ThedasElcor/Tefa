using Tefa.Domain.Entities.Junctions;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRGroupEventParticipation : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public GroupEvent? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public GroupEventInst? EntityInstance { get; set; }
    }
}
