using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Entities.FandomCore.Conlangs;
using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.ConlangAssociations
{
    public class CharacterCANote : LocalizedNote
    { 
        public required int CharacterId { get; set; }
        public required Character Character { get; set; }
        public required int ConlangId { get; set; }
        public required Conlang Conlang { get; set; }
    }
}
