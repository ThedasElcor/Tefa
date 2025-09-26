using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.EventParticipants
{
    public class SpeciesEPNote : LocalizedNote
    {
        public required int SpeciesSPId { get; set; }
        public required SpeciesEP SpeciesEP { get; set; }
    }
}
