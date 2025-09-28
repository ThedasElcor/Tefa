using Tefa.Domain.Entities.Junctions;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.ChangeRequests
{
    public class CRSpeciesLanguageAssociation : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public SpeciesLocation? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public SpeciesLocationInst? EntityInstance { get; set; }
    }
}
