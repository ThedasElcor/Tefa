using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    public class SpeciesGroupNote : LocalizedNote
    {
        public required int SpeciesGroupId { get; set; }
        public required SpeciesGroup SpeciesGroup { get; set; }
    }
}
