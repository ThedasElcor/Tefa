using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Metadata.MediaAppearances
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class GroupMedia
    {
        public required int Id { get; set; }
        public required int GroupId { get; set; }
        public required Group Group { get; set; }
        public required int MediaId { get; set; }
        public required Media Media {  get; set; }
        public required MediaAppearanceType AppearanceType { get; set; }
        public ICollection<GroupMediaNote> Notes { get; set; } = [];
    }
}
