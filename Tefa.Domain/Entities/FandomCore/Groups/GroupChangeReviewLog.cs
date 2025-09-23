using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.Groups
{
    public class GroupChangeReviewLog
    {
        public required int Id { get; set; }
        public int ChangeRequestId { get; set; }
        public required GroupChangeRequest ChangeRequest { get; set; }
        public ICollection<ReviewEntry> ReviewEntries { get; set; } = [];
    }
}
