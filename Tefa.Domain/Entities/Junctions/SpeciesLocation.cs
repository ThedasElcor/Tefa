
namespace Tefa.Domain.Entities.Junctions
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class SpeciesLocation
    {
        public required int Id { get; set; }
        public required int LocationId { get; set; }
        public required Location Location { get; set; }
        public required Species Species {  get; set; }
        public ICollection<SpeciesLocationNote> Notes { get; set; } = [];
    }
}
