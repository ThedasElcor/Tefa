using Tefa.Domain.CognitiveLoadJail.Entities.FandomCore.Locations;

namespace Tefa.Domain.Entities.ChangeRequests
{
   public class CRLocation : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public Location? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public LocationInstance? EntityInstance { get; set; }
    }
}
