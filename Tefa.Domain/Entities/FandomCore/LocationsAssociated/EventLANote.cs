using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.LocationsAssociated
{
    public class EventLANote : LocalizedNote
    {
        public required int EventLAId { get; set; }
        public required EventLA EventLA { get; set; }
    }
}
