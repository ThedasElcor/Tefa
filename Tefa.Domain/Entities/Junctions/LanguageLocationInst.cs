
using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class LanguageLocationInst : Instance
    {
        public required int LanguageLocationId { get; set; }
        public required LanguageLocation LanguageLocation { get; set; }
    }
}

