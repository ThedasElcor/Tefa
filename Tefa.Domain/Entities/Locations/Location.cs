using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Locations
{
    public class Location
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required LocationType Type { get; set; }
        public FandomId? OriginalFandomId { get; set; }
        public Fandom? OriginalFandom { get; set; }
        public Location? RootVariant { get; set; }
        public ICollection<LocationVariantLink> VariantOf { get; set; } = [];
        public ICollection<LocationVariantLink> Variants { get; set; } = [];
    }
}
