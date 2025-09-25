using Tefa.Domain.Entities.FandomCore.Events;
using Tefa.Domain.Entities.FandomCore.Locations;

namespace Tefa.Domain.Entities.FandomCore.LocationsAssociated
{
    public class EventLAInstance
    {
        public required int EventId { get; set; }
        public required Event Event { get; set; }
        public required int LocationId { get; set;}
        public required Location Location { get; set; }
    }
}
