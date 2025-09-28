using Tefa.Domain.Entities;
using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.CognitiveLoadJail.Entities
{
    public class SpeciesEPInstance : Instance
    {
        public required int SpeciesId { get; set; }
        public required SpeciesInst Species { get; set; }
        public required int EventId { get; set; }
        public required EventInstance Event {  get; set; }
    }
}
