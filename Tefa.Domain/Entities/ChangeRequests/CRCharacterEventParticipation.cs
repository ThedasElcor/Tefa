using Tefa.Domain.Entities.FandomCore.EventParticipants;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRCharacterEventParticipation : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public CharacterEP? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public CharacterEPInstance? EntityInstance { get; set; }
    }
}
