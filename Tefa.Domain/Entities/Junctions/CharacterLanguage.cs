using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Junctions
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class CharacterLanguage
    {
        public required int Id { get; set; }
        public required int CharacterId { get; set; }
        public required Character Character { get; set; }
        public required int ConlangId { get; set; }
        public required Conlang Conlang { get; set; }
        public required LanguageFluency Fluency { get; set; }
    }
}

