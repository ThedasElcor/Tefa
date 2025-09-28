using Tefa.Domain.CognitiveLoadJail.Entities;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.ChangeRequests
{
    public class CRFandomMedia : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public FandomMedia? ExistingEntity { get; set; }
    }
}
