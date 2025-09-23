using Tefa.Domain.Entities.Users;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.Groups
{
    public class GroupChangeRequest
    {
        public required int Id { get; set; }
        // Change Request Metadata
        public int? ExistingGroupId { get; set; }
        public Group? ExistingGroup { get; set; }
        public required string UserRequested { get; set; }
        public required ApplicationUser RequestedBy { get; set; }
        public DateTime DateRequested { get; set; } = DateTime.UtcNow;
        public ChangeTypeEnum ChangeType { get; set; }
        public GroupInstance? GroupInstance { get; set; } //To be compared with current canon version for complex change requests
        public string? FreeformNotes { get; set; }
        public Status Status { get; set; }
        public int? ReviewLogId { get; set; }
        public GroupChangeReviewLog? ReviewLog { get; set; }
    }
}
