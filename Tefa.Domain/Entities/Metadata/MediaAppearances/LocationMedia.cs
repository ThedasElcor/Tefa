using Tefa.Domain.CognitiveLoadJail.Entities.FandomCore.Locations;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Metadata.MediaAppearances
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class LocationMedia
    {
        public required int Id { get; set; }
        public required int LocationId { get; set; }
        public required Location Location { get; set; }
        public required int MediaId { get; set; }
        public required Media Media { get; set; }
        public required MediaAppearanceType AppearanceType { get; set; }
        public ICollection<LocationMediaNote> Notes { get; set; } = [];
    }
}
