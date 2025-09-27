using Tefa.Domain.Enums.Language;

namespace Tefa.Domain.Entities.Shared
{
    public abstract class LanguageTag
    {
        public required Language Language { get; set; }
    }
}
