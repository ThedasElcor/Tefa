using Tefa.Domain.CognitiveLoadJail.Entities;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRFandomMedia : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public FandomMedia? ExistingEntity { get; set; }
    }
}
