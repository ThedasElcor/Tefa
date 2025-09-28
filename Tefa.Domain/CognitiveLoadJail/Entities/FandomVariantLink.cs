using Tefa.Domain.CognitiveLoadJail.Enums;

namespace Tefa.Domain.CognitiveLoadJail.Entities
{
    public class FandomVariantLink
    {
        public FandomId ParentFandomId { get; set; }
        public required Fandom ParentFandom { get; set; }
        public FandomId SubfandomId { get; set; }
        public required Fandom Subfandom { get; set; }
        public string? SysNotes { get; set; }
    }
}
