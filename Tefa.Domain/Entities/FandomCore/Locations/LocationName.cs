using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.Locations
{
    public class LocationName : LocalizedName
    {
        public required int LocationId { get; set; }
        public required Location Location { get; set; }
    }
}
