using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.GroupParticipants
{
    public class CharacterGPNote : LocalizedNote
    {
        public required int CharacterGPId { get; set; }
        public required CharacterGP CharacterGP { get; set; }
    }
}
