using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Abstract
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public abstract class LocalizedName
    {
        public required int Id { get; set; }
        public required Language Language { get; set; }
        public bool IsPreferred { get; set; } // Is this the main name in this language?
        public required string Name { get; set; }
        public string? Notes { get; set; }
    }
}
