using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Enums.Language;

namespace Tefa.Domain.Entities.FandomCore.ConlangAssociations
{
    public class CharacterCA
    {
        public required int Id { get; set; }
        public required int CharacterId { get; set; }
        public required Character Character { get; set; }
        public required int ConlangId { get; set; }
        public required CharacterCA Conlang { get; set; }
        public required LanguageFluency Fluency { get; set; }
        public ICollection<CharacterCANote> Notes { get; set; } = [];
    }
}
