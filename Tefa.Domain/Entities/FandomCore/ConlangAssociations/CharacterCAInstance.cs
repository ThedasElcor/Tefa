using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Entities.FandomCore.Conlangs;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums.Language;

namespace Tefa.Domain.Entities.FandomCore.ConlangAssociations
{
    public class CharacterCAInstance : Instance
    { 
        public required int CharacterId { get; set; }
        public required CharacterInstance Character { get; set; }
        public required int ConlangId { get; set; }
        public required ConlangInstance Conlang { get; set; }
        public required LanguageFluency Fluency { get; set; }
        public string? Note {  get; set; }
    }
}
