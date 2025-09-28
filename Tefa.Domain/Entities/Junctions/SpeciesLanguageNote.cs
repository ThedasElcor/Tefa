using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    public class SpeciesLanguageNote : LocalizedNote
    {
        public required int SpeciesLanguageId { get; set; }
        public required SpeciesLanguage SpeciesLanguage { get; set; } = [];
    }
}
