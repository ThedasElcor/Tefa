using Tefa.Domain.Entities.Abstract;
using Tefa.Domain.Entities.Metadata.Media;

namespace Tefa.Domain.Entities.Metadata
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class MediaReleaseNote : LocalizedNote
    {
        public required int MediaReleaseId { get; set; }
        public required MediaRelease MediaRelease { get; set; }
    }
}
