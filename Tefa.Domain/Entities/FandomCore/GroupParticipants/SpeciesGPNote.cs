using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.GroupParticipants
{
    public class SpeciesGPNote : LocalizedNote
    {
        public required int SpeciesGPId { get; set; }
        public required SpeciesGP SpeciesGP { get; set; }
    }
}
