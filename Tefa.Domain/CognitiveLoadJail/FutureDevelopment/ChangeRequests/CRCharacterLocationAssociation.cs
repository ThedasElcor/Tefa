using Tefa.Domain.Entities.Junctions;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.ChangeRequests
{
    public class CRCharacterLocationAssociation : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public CharacterLocation? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public CharacterLocationInst? EntityInstance { get; set; }
    }
}
