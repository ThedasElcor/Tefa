using Tefa.Domain.Entities.FandomCore.LocationsAssociated;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRSpeciesLanguageAssociation : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public SpeciesLA? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public SpeciesLAInstance? EntityInstance { get; set; }
    }
}
