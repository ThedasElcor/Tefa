using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.Species
{
    public class SpeciesName : LocalizedName
    {
        public required int SpeciesId { get; set; }
        public required SpeciesItem Species { get; set; }
    }
}
