
using Tefa.Domain.Entities.Events;
using Tefa.Domain.Entities.Locations;
using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.Junctions
{
    public class EventLocation
    {
        public required int Id { get; set; }
        public required int EventId { get; set; }
        public required Event Event { get; set; }
        public required int LocationId { get; set; }
        public required Location Location { get; set; }
        public ICollection<Nuance> NuanceNotes { get; set; } = [];
    }
}
