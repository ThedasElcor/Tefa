using Tefa.Domain.Entities.Users;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class ReviewEntry
    {
        public required string ReviewedByName { get; set; }
        public required ApplicationUser ReviewedBy {  get; set; }
        public DateTime ReviewedOn { get; set; } = DateTime.Now;
        public string? ReviewNotes { get; set; }
    }
}
