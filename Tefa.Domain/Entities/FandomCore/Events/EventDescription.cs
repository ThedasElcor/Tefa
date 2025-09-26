using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.Events
{
    public class EventDescription : LocalizedNote
    {
        public required int EventId { get; set; }
        public required Event Event { get; set; }
    }
}
