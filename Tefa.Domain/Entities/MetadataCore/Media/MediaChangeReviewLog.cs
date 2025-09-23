using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.MetadataCore.Media
{
    public class MediaChangeReviewLog
    {
        public required int Id { get; set; }
        public required int ChangeRequestId { get; set; }
        public required MediaChangeRequest ChangeRequest { get; set; }
        public ICollection<ReviewEntry> ReviewEntries { get; set; } = [];
    }
}
