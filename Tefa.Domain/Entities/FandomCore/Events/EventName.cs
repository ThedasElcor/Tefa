using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.Events
{
    public class EventName : LocalizedName
    {
        public required int EventId { get; set; }
        public required Event Event { get; set; }
    }
}
