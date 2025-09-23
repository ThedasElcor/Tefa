using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.Locations
{
    public class LocationChangeReviewLog
    {
        public required int Id   { get; set; }
        public required int ChangeRequestId { get; set; }
        public required LocationChangeRequest ChangeRequest { get; set; }
        public ICollection<ReviewEntry> ReviewEntires { get; set; } = [];
    }
}
