using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Entities.FandomCore.Events;
using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.EventParticipants
{
    public class CharacterEPInstance : Instance
    {
        public required int CharacterId { get; set; }
        public required CharacterInstance Character { get; set; }
        public required int EventId { get; set; }
        public required EventInstance Event { get; set; }
    }
}
