using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities
{
    public class EventNote : LocalizedNote
    {
        public required int EventId { get; set; }
        public required Event Event { get; set; }
    }
}
