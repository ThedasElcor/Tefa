using Tefa.Domain.Entities.Events;
using Tefa.Domain.Entities.Groups;
using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.Junctions
{
    public class EventGroup
    {
        public required int Id { get; set; }
        public required int EventId { get; set; }
        public required Event Event { get; set; }
        public required int GroupId { get; set; }
        public required Group Group { get; set; }
        public ICollection<Nuance> NuanceNotes { get; set; } = [];
    }
}
