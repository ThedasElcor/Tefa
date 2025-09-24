using Tefa.Domain.Entities.FandomCore.GroupParticipants;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRCharacterGroupParticipation : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public CharacterGP? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public CharacterGPInstance? EntityInstance { get; set; }
    }
}
