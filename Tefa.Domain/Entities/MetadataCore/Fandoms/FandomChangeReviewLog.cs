using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.MetadataCore.Fandoms
{
    public class FandomChangeReviewLog
    {
        public required int Id { get; set; }
        public required int ChangeRequestId { get; set; }
        public required FandomChangeRequest ChangeRequest {  get; set; }
        public ICollection<ReviewEntry> ReviewEntries { get; set; } = [];
    }
}
