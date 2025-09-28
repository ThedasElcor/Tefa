using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.CognitiveLoadJail.Entities
{
    public class EventName : LocalizedName
    {
        public required int EventId { get; set; }
        public required Event Event { get; set; }
    }
}
