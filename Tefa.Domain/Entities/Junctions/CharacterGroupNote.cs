using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class CharacterGroupNote : LocalizedNote
    {
        public required int CharacterGroupId { get; set; }
        public required CharacterGroup CharacterGroup { get; set; }
    }
}
