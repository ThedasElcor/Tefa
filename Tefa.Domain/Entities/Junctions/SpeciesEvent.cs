using Tefa.Domain.Entities;

namespace Tefa.Domain.Entities.Junctions
{
 public class SpeciesEvent
    {
        public required int EventId { get; set; }
        public required Event Event { get; set; }
        public required int SpeciesId { get; set; }
        public required Species Species {  get; set; }
        public ICollection<SpeciesEventNote> Notes { get; set; } = [];
    }
}
