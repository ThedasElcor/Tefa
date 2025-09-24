using Tefa.Domain.Entities.FandomCore.LocationsAssociated;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CREventLocationAssociation
    {
        public int? ExistingEntityId { get; set; }
        public EventLA? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public EventLAInstance? EntityInstance { get; set; }
    }
}
