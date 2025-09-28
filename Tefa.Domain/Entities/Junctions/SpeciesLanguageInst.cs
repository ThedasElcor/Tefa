using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    public class SpeciesLanguageInst : Instance
    {
        public required int SpeciesId { get; set; }
        public required SpeciesInst Species {  get; set; }
        public required int LanguageId { get; set; }
        public required ConlangInst Language { get; set; }
    }
}
