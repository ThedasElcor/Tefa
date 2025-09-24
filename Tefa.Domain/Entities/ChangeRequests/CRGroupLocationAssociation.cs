using Tefa.Domain.Entities.FandomCore.LocationsAssociated;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRGroupLocationAssociation : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public GroupLA? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public GroupLAInstance? EntityInstance { get; set; }
    }
}
