using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Abstract
{
    public abstract class LocalizedNote
    {
        public required int Id { get; set; }
        public required Language Language { get; set; }
        public string Text { get; set; } = string.Empty;
    }
}
