using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class LocationMediaNote : LocalizedNote
    {
        public required int LocationMAId { get; set; }
        public required LocationMedia  LocationMA { get; set; }
    }
}
