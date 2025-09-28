using Tefa.Domain.Entities.Junctions;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.ChangeRequests
{
    public class CRCharacterGroupParticipation : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public CharacterGroup? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public CharacteGroupInst? EntityInstance { get; set; }
    }
}
