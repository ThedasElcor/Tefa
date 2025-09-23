using Tefa.Domain.Entities.Users;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Fandoms
{
    public class FandomChangeRequest
    {
        // Change Request Metadata
        public required int Id { get; set; }
        public Fandom? ExistingFandom { get; set; }
        public required string UserRequested { get; set; }
        public required ApplicationUser RequestedBy { get; set; }
        public DateTime DateRequested { get; set; } = DateTime.UtcNow;
        public ChangeTypeEnum ChangeType { get; set; }
        public Status Status { get; set; }
        public int? ReviewLogId { get; set; }
        public FandomChangeReviewLog? ReviewLog { get; set; }

        // Change Request Content
        public string FreeformNotes { get; set; } = string.Empty;
        public Fandom? ParentFandom { get; set; }
        public ICollection<Fandom> Subfandoms { get; set; } = [];
        public ICollection<FandomName> FandomNames { get; set; } = [];
    }
}
