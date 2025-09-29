using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Metadata.MediaAppearances
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class SpeciesMediaNote : LocalizedNote
    {
        public required int SpeciesMAId { get; set; }
        public required SpeciesMedia SpeciesMA { get; set; }
    }
}
