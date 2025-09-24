using Tefa.Domain.Entities.FandomCore.Conlangs;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRConlang : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public Conlang? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
       public ConlangInstance? EntityInstanceInstance { get; set; }
    }
}
