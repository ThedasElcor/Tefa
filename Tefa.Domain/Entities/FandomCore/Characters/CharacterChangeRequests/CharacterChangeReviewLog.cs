using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.Characters.CharacterChangeRequest
{
    public class CharacterChangeReviewLog
    {
        public required int Id { get; set; }
        public int ChangeRequestId { get; set; }
        public required CharacterChangeRequest ChangeRequest { get; set; }
        public ICollection<ReviewEntry> ReviewEntries { get; set; } = [];
    }
}
