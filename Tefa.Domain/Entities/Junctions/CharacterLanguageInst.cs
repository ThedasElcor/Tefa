using Tefa.Domain.Entities.Abstract;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Junctions
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class CharacterLanguageInst : Instance
    {
        public required int CharacterId { get; set; }
        public required CharacterInst Character { get; set; }
        public required int ConlangId { get; set; }
        public required ConlangInst Conlang { get; set; }
        public required LanguageFluency Fluency { get; set; }
    }
}

