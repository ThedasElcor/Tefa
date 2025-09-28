using Tefa.Domain.CognitiveLoadJail.Entities;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.ChangeRequests
{
    public class CREvent : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public Event? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public EventInstance? EntityInstance { get; set; }
    }
}
