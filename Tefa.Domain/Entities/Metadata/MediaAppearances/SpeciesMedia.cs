using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Metadata.MediaAppearances
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class SpeciesMedia
    {
        public required int Id { get; set; }
        public required int MediaId { get; set; }
        public required Media Media { get; set; }
        public required int SpeciedId { get; set; }
        public required Species Species {  get; set; }
        public required MediaAppearanceType EntityAppearanceType { get; set; }
        public ICollection<SpeciesMediaNote> Notes { get; set; } = [];

    }
}
