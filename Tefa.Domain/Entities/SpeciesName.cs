using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities
{
    public class SpeciesName : LocalizedName
    {
        public required int SpeciesId { get; set; }
        public required Species Species { get; set; }
    }
}
