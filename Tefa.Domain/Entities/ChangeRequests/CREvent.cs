using Tefa.Domain.Entities;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CREvent : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public Event? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public EventInst? EntityInstance { get; set; }
    }
}
