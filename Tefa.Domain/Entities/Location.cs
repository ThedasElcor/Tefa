using Tefa.Domain.Entities.Tags;

namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class Location
    {
        public required int Id { get; set; }
        public ICollection<LocationName> Names { get; set; } = [];
        public ICollection<LocationTypeTag> TypeTags { get; set; } = [];
        public ICollection<LocationNote> Notes { get; set; } = [];
        public ICollection<LocationInst> Instances { get; set; } = [];
    }
}

