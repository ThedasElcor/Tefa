using Tefa.Domain.Entities.Characters;
using Tefa.Domain.Entities.FandomCore;
using Tefa.Domain.Entities.Users;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Media
{
    public class MediaChangeRequest
    {
        public required int Id { get; set; }
        // Change Request Metadata
        public MediaItem? ExistingMedia { get; set; }
        public required string RequestedByName { get; set; }
        public required ApplicationUser RequestedBy { get; set; }
        public DateTime DateRequested { get; set; } = DateTime.UtcNow;
        public ChangeTypeEnum ChangeType { get; set; }
        public Status Status { get; set; }
        public CharacterChangeReviewLog? ReviewLog { get; set; }

        // Change Request Content
        public string FreeformNotes { get; set; } = string.Empty;
        public required string Name { get; set; }
        public string? Disambiguation { get; set; }
    }
}
