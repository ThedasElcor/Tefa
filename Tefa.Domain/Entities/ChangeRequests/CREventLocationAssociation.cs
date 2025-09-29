using Tefa.Domain.Entities.Junctions;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CREventLocationAssociation
    {
        public int? ExistingEntityId { get; set; }
        public EventLocation? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public EventLocationInst? EntityInstance { get; set; }
    }
}
