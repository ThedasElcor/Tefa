
using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class LocationNote : LocalizedNote
    {
        public required int LocationId { get; set; }
        public required Location Location { get; set; }
    }
}

