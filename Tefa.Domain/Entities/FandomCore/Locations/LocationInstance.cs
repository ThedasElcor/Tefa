using Tefa.Domain.Entities.Community;
using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.Locations
{
    public class LocationInstance : Instance
    {
        public required int LocationId { get; set; }
        public required Location Location { get; set; }


    }
}
