using Tefa.Domain.Entities.FandomCore.Groups;
using Tefa.Domain.Entities.FandomCore.Locations;
using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.LocationsAssociated
{
    public class GroupLAInstance : Instance
    {
        public required int GroupId { get; set; }
        public required GroupInstance Group { get; set; }
        public required int LocationId { get; set; }
        public required Location Location { get; set; }
    }
}
