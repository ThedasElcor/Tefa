namespace Tefa.Domain.Entities.Junctions
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class SpeciesLanguage
    {
        public required int SpeciesId { get; set; }
        public required Species Species { get; set; }
        public required int LanguageId { get; set; }
        public required Conlang Language { get; set; }
        public ICollection<SpeciesLanguageNote> Notes { get; set; } = [];
    }
}
