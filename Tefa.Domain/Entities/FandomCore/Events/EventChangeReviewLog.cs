using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.Events
{
    public class EventChangeReviewLog
    {
        public required int Id { get; set; }
        public int ChangeRequestId { get; set; }
        public required EventChangeRequest ChangeRequest { get; set; }
        public ICollection<ReviewEntry> ReviewEntries { get; set; } = [];
    }
}
