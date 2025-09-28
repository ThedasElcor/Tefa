using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    public class EventLocationNote : LocalizedNote
    {
        public required int EventLocationId { get; set; }
        public required EventLocation EventLocation { get; set; }
    }
}
