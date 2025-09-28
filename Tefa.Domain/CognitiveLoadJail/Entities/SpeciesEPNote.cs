using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.CognitiveLoadJail.Entities
{
    public class SpeciesEPNote : LocalizedNote
    {
        public required int SpeciesSPId { get; set; }
        public required SpeciesEP SpeciesEP { get; set; }
    }
}
