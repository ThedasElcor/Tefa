using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.Species
{
    public class SpeciesChangeReviewLog
    {
        public required int Id { get; set; }
        public required SpeciesChangeRequest ChangeRequest { get; set; }
        public ICollection<ReviewEntry> ReviewEntries { get; set; } = [];
    }
}
