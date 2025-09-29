namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class ConlangVariantLink
    {
        public required int GeneralConlangId { get; set; }
        public required Conlang GeneralConlang { get; set; }
        public required int SpecificConlangId { get; set; }
        public required Conlang SpecificConlang { get; set; }
        public string? SysNotes { get; set; }
    }
}
