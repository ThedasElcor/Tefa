using Tefa.Domain.Enums.Language;

namespace Tefa.Domain.Entities.Shared
{
    public abstract class LocalizedName
    {
        public required int Id { get; set; }
        public required Language Language { get; set; }
        public bool IsPreferred { get; set; } // Is this the main name in this language?
        public required string Name { get; set; }
        public string? Notes { get; set; }
    }
}
