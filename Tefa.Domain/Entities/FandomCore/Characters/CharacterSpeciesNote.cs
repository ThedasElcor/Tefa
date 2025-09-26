using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.Characters
{
    public class CharacterSpeciesNote : LocalizedNote
    {
        public required int CharacterId { get; set; }
        public required Character   Character { get; set; }
        public required int SpeciesId { get; set; }
        public required int Species { get; set; }
    }
}
