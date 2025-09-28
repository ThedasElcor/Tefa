using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    public class SpeciesLocationNote : LocalizedNote
    {
        public required int SpeciesLocationId { get; set; }
        public required SpeciesLocation SpeciesLocation { get; set; }
    }
}
