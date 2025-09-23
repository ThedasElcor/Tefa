using Tefa.Domain.Entities.Characters;
using Tefa.Domain.Entities.Locations;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Junctions
{
    public class CharacterLocation
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
