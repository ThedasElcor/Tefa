using Tefa.Domain.Entities;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRRelationship : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public Relationship? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public RelationshipInst? EntityInstance { get; set; }
    }
}
