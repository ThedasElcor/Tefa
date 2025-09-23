using Tefa.Domain.Entities.Users;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Characters
{
    public class CharacterChangeRequest
    {
        // Change Request Metadata
        public required int Id { get; set; }
        public int? ExistingCharacterId { get; set; }
        public Character? ExistingCharacter { get; set; }
        public required string UserRequested {  get; set; }
        public required ApplicationUser RequestedBy { get; set; }
        public DateTime DateRequested { get; set; } = DateTime.UtcNow;
        public ChangeTypeEnum ChangeType { get; set; }
        public Status Status { get; set; }
        public int? ReviewLogId { get; set; }
        public CharacterChangeReviewLog? ReviewLog { get; set; }

        //Change Request Content
        public CharacterInstance? CharacterInstance { get; set; } //To be compared with current canon version for complex change requests
        public string? FreeformNotes { get; set; }
                
    }
}
