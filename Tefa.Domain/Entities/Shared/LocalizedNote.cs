using Tefa.Domain.Enums.Language;

namespace Tefa.Domain.Entities.Shared
{
    public abstract class LocalizedNote
    {
        public required int Id { get; set; }
        public required Language Language { get; set; }
        public string Text { get; set; } = string.Empty;
    }
}
