using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.Relationships
{
    public class RelationshipChangeReviewLog
    {
        public required int Id { get; set; }
        public required int ChangeRequestId { get; set; }
        public required RelationshipChangeRequest ChangeRequest { get; set; }
        public ICollection<ReviewEntry> ReviewEntries { get; set; } = [];
    }
}
