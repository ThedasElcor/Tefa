using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    public class SpeciesLocationInst : Instance
    {
        public required int SpeciesId { get; set; }
        public required SpeciesInst Species { get; set; }
        public required int AssociatedLocationId { get; set; }
        public required LocationInst AssociatedLocation {get; set;}
    }
}
