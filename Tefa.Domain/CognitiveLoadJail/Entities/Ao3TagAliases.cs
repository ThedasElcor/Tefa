using Tefa.Domain.Enums;

namespace Tefa.Domain.CognitiveLoadJail.Entities
{
    public class Ao3TagAliases
    {
        public required int Ao3Tag1Id { get; set; }
        public required Ao3Tag Tag1 { get; set; }
        public required int Ao3Tag2Id  { get; set; }
        public required Ao3Tag Tag2 { get; set; }
        public string? SysNotes { get; set; }
        public Status AliasStatus { get; set; } = Status.Pending;
    }
}
