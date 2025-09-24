using Tefa.Domain.Entities.MetadataCore.Fandoms;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRFandom
    {
        public int? ExistingEntityId {  get; set; }
        public Fandom? ExistingEntity { get; set; }
    }
}
