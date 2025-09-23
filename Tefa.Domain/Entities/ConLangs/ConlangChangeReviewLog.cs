using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.ConLangs
{
    public class ConlangChangeReviewLog
    {
        public required int Id { get; set; }
        public required int ChangeRequestId { get; set; }
        public required ConLangChangeRequest ChangeRequest { get; set; }
        public ICollection<ReviewEntry> ReviewEntries { get; set; } = [];
    }
}
