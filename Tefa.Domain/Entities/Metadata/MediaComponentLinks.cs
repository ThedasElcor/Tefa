namespace Tefa.Domain.Entities.Metadata
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class MediaComponentLinks
    {
        public required int CompositeMediaId { get; set; }
        public required Media CompositeMedia {  get; set; }
        public required int ComponentMediaId { get; set; }
        public required Media ComponentMedia { get; set; }
    }
}
