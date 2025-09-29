using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Metadata
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class MediaName : LocalizedName
    {
        public required int MediaId { get; set; }
        public required Media Media {  get; set; }
    }
}
