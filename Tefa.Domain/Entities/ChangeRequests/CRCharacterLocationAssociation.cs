using Tefa.Domain.Entities.FandomCore.LocationsAssociated;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRCharacterLocationAssociation : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public CharacterLA? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public CharacterLAInstance? EntityInstance { get; set; }
    }
}
