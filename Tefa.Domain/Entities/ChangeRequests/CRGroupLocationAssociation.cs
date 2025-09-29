using Tefa.Domain.Entities.Junctions;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRGroupLocationAssociation : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public GroupLA? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public GroupLocationInst? EntityInstance { get; set; }
    }
}
