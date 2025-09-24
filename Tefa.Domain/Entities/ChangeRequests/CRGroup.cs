using Tefa.Domain.Entities.FandomCore.Groups;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRGroup : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public Group? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public GroupInstance? EntityInstance { get; set; }
    }
}
