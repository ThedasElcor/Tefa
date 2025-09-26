using Tefa.Domain.Entities.FandomCore.Groups;
using Tefa.Domain.Entities.FandomCore.Species;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.GroupParticipants
{
    public class SpeciesGP
    {
        public required int GroupId { get; set; }
        public required Group Group { get; set; }
        public required int SpeciesId { get; set; }
        public required SpeciesItem Species {  get; set; }
        public ICollection<AffiliationType> AffiliationTypes { get; set; } = [];
        public ICollection<SpeciesGPNote> Notes { get; set; } = [];
    }
}
