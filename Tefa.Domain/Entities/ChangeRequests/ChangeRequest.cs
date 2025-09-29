using Tefa.Domain.Entities.Users;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public abstract class ChangeRequest
    {
        public required int Id { get; set; }
        public required string UserRequested { get; set; }
        public required ApplicationUser RequestedBy { get; set; }
        public DateTime DateRequested { get; set; } = DateTime.UtcNow;
        public ChangeType ChangeType { get; set; }
        public Status Status { get; set; }
        public string? FreeformNotes { get; set; }
        public ICollection<ReviewEntry> ReviewEntries { get; set; } = [];
    }
}
