using Tefa.Domain.Entities.FandomCore.Events;
using Tefa.Domain.Entities.FandomCore.Locations;
using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.LocationsAssociated
{
    public class EventLA
    {
        public required int Id { get; set; }
        public required int EventId { get; set; }
        public required Event Event { get; set; }
        public required int LocationId { get; set; }
        public required Location Location { get; set; }
        public ICollection<LocalizedNote> NuanceNotes { get; set; } = [];
    }
}
