using Tefa.Domain.Entities.FandomCore.Relationships;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRRelationship : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public Relationship? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public RelationshipInstance? EntityInstance { get; set; }
    }
}
