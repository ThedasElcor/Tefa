using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Entities.FandomCore.Locations;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.LocationAssociations
{
    public class CharacterLA
    {
        public required int Id { get; set; }
        public required int CharacterId { get; set; }
        public required Character Character {  get; set; }
        public required int LocationId { get; set; }
        public required Location Location { get; set; }
        public ICollection<AffiliationType> AffiliationTypes { get; set; } = [];
        public ICollection<Nuance> NuanceNotes { get; set; } = [];
    }
}
