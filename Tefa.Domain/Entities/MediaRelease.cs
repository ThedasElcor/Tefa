namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class MediaRelease
    {
        public required string ReleaseName { get; set; }
        public required DateTime ReleaseDate {get; set;}
        public required string ReleaseLocale { get; set;}
        public ICollection<MediaReleaseNote> ReleaseNotes { get; set; } = [];
    }
}
