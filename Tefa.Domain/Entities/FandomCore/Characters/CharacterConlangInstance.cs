using Tefa.Domain.Entities.FandomCore.Conlangs;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.Characters
{
    public class CharacterConlangInstance : Instance
    { 
        public required int CharacterId { get; set; }
        public required CharacterInstance Character { get; set; }
        public required int ConlangId { get; set; }
        public required ConlangInstance Conlang { get; set; }
        public required LanguageFluency Fluency { get; set; }

    }
}
