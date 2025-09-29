using Tefa.Domain.Entities;
using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    public class SpeciesEventInst : Instance
    {
        public required int SpeciesId { get; set; }
        public required SpeciesInst Species { get; set; }
        public required int EventId { get; set; }
        public required EventInst Event {  get; set; }
    }
}
