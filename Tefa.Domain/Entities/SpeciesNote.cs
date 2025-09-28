using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class SpeciesNote : LocalizedNote
    {
        public required int SpeciesId { get; set; }
        public required Species Species {  get; set; }
    }
}

