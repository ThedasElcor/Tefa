using Tefa.Domain.Entities.MetadataCore.Fandoms;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRFandomMedia : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public FandomMedia? ExistingEntity { get; set; }
    }
}
