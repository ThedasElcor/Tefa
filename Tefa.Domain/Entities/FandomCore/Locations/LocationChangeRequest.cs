using Tefa.Domain.Entities.Users;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.Locations
{
   public class LocationChangeRequest
    {
        public required int Id { get; set; }
        // Change Request Metadata
        public Location? ExistingLocation { get; set; }
        public required string RequestedByName { get; set; }
        public required ApplicationUser RequestedBy { get; set; }
        public DateTime DateRequested { get; set; } = DateTime.UtcNow;
        public ChangeTypeEnum ChangeType { get; set; }
        public Status Status { get; set; }
        public int? ReviewLogId {  get; set; }
        public LocationChangeReviewLog? ReviewLog { get; set; }

        // Change Request Content
        public string FreeformNotes { get; set; } = string.Empty;
        public string? Name { get; set; }
        public LocationType? Type { get; set; }
        public FandomId? OriginalFandomId { get; set; }
    }
}
