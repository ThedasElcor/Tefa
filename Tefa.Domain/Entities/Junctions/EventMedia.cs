using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Junctions
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class EventMedia
    {
        public required int Id { get; set; }
        public required int EventId { get; set; }
        public required Event Event { get; set; }
        public required int MediaId { get; set; }
        public required Media Media {  get; set; }
        public required MediaAppearanceType AppearanceType { get; set; }
        public ICollection<EventMediaNote> Notes { get; set; } = [];
    }
}
