using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class GroupLanguageInst : Instance
    {
        public required int GroupId { get; set; }
        public required GroupInst Group { get; set; }
        public required int LanguageId { get; set; }
        public required ConlangInst Language { get; set; }
    }
}
