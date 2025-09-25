
using Tefa.Domain.Entities.FandomCore.Events;
using Tefa.Domain.Entities.FandomCore.Species;
using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.EventParticipants
{
    public class SpeciesEPInstance : Instance
    {
        public required int SpeciesId { get; set; }
        public required SpeciesInstance Species { get; set; }
        public required int EventId { get; set; }
        public required EventInstance Event {  get; set; }
    }
}
