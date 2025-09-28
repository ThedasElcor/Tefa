using Tefa.Domain.Entities;

namespace Tefa.Domain.CognitiveLoadJail.Entities
{
 public class SpeciesEP
    {
        public required int EventId { get; set; }
        public required Event Event { get; set; }
        public required int SpeciesId { get; set; }
        public required Species Species {  get; set; }
        public ICollection<SpeciesEPNote> Notes { get; set; } = [];
    }
}
