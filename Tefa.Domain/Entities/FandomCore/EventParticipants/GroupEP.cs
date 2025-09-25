using Tefa.Domain.Entities.FandomCore.Events;
using Tefa.Domain.Entities.FandomCore.Groups;
using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.EventParticipants
{
    public class GroupEP
    {
        public required int Id { get; set; }
        public required int EventId { get; set; }
        public required Event Event { get; set; }
        public required int GroupId { get; set; }
        public required Group Group { get; set; }
        public ICollection<LocalizedNote> NuanceNotes { get; set; } = [];
    }
}
