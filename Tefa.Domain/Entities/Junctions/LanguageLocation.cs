
namespace Tefa.Domain.Entities.Junctions
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class LanguageLocation
    {
        public required int LanguageId { get; set; }
        public required Conlang Language {  get; set; }
        public required int LocationId { get; set; }
        public required Location Location { get; set; }
        public ICollection<LanguageLocationNote> Notes { get; set; } = [];
    }
}

