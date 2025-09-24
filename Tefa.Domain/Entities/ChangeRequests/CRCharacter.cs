using Tefa.Domain.Entities.FandomCore.Characters;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRCharacter : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public Character? ExistingEntity { get; set; }     
        public int? EntityInstanceId { get; set; }
        public CharacterInstance? EntityInstance { get; set; }
    }
}
