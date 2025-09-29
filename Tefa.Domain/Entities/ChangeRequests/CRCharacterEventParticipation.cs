using Tefa.Domain.Entities.Junctions;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRCharacterEventParticipation : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public CharacterEvent? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public CharacterEventInst? EntityInstance { get; set; }
    }
}
