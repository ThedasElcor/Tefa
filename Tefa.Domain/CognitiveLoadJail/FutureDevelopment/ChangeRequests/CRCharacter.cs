using Tefa.Domain.Entities;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.ChangeRequests
{
    public class CRCharacter : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public Character? ExistingEntity { get; set; }     
        public int? EntityInstanceId { get; set; }
        public CharacterInst? EntityInstance { get; set; }
    }
}
