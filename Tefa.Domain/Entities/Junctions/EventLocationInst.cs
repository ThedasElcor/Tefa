using Tefa.Domain.CognitiveLoadJail.Entities.FandomCore.Locations;
using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    public class EventLocationInst : Instance
    {
        public required int EventId { get; set; }
        public required EventInst Event { get; set; }
        public required int LocationId { get; set;}
        public required LocationInstance Location { get; set; }
    }
}
