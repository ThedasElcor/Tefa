using Tefa.Domain.Entities.FandomCore.Species;


namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRSpecies : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public SpeciesItem? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public SpeciesInstance? EntityInstance { get; set; }
    }
}
