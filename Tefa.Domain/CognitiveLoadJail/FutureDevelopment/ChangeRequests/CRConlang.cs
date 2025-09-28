using Tefa.Domain.Entities;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.ChangeRequests
{
    public class CRConlang : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public Conlang? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
       public ConlangInst? EntityInstanceInstance { get; set; }
    }
}
