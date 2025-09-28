using Tefa.Domain.CognitiveLoadJail.Entities;
using Tefa.Domain.CognitiveLoadJail.Entities.FandomCore.Locations;

namespace Tefa.Domain.Entities.Junctions
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class EventLocation
    {
        public required int Id { get; set; }
        public required int EventId { get; set; }
        public required Event Event { get; set; }
        public required int LocationId { get; set; }
        public required Location Location { get; set; }
        public ICollection<EventLocationNote> Notes { get; set; } = [];
    }
}
