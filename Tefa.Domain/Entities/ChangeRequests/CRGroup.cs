using Tefa.Domain.Entities;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRGroup : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public Group? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public GroupInst? EntityInstance { get; set; }
    }
}
