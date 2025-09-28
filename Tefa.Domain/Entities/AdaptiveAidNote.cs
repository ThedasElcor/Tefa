
using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class AdaptiveAidNote : LocalizedNote
    {
        public required int AdaptiveAidId { get; set; }
        public required AdaptiveAid AdaptiveAid { get; set; }
    }
}

