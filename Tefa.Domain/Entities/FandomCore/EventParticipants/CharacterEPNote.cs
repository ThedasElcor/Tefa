using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.EventParticipants
{
    public class CharacterEPNote : LocalizedNote
    {
        public required int CharacterEPId { get; set; }
        public required CharacterEP CharacterEP { get; set; }
    }
}
