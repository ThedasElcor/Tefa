using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.Characters
{
    public class CharacterChangeReviewLog
    {
        public required int Id { get; set; }
        public int ChangeRequestId { get; set; }
        public required CharacterChangeRequest ChangeRequest { get; set; }
        public ICollection<ReviewEntry> ReviewEntries { get; set; } = [];
    }
}
