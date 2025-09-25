using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.Characters
{
    public class CharacterConlang
    {
        public required int Id { get; set; }
        public required int CharacterId { get; set; }
        public required Character Character { get; set; }
        public required int ConlangId { get; set; }
        public required CharacterConlang Conlang { get; set; }
        public required LanguageFluency Fluency { get; set; }
        public ICollection<LocalizedNote> Notes { get; set; } = [];
    }
}
