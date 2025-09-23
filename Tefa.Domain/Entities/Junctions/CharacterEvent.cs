using Tefa.Domain.Entities.Characters;
using Tefa.Domain.Entities.Events;
using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.Junctions
{
    public class CharacterEvent
    {
        public required int Id { get; set; }
        public required int CharacterId { get; set; }
        public required Character Character { get; set; }
        public required int EventId { get; set; }
        public required Event Event { get; set; }
        public ICollection<Nuance> NuanceNotes { get; set; } = [];
    }
}
