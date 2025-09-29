using Tefa.Domain.Entities;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRSpecies : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public Species? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public SpeciesInst? EntityInstance { get; set; }
    }
}
