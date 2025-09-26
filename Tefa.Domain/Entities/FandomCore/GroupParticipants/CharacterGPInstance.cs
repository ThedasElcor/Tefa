using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Entities.FandomCore.Groups;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.GroupParticipants
{
    public class CharacterGPInstance : Instance
    {
        public required int CharacterInstanceId { get; set; }
        public required CharacterInstance CharacterInstance { get; set; }
        public required int GroupInstanceId { get; set; }
        public required GroupInstance GroupInstance { get; set; }
        public ICollection<AffiliationType> AffiliationTypes { get; set; } = [];
    }
}
