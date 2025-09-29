using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Metadata.MediaAppearances
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class CRCondition : ChangeRequest
    {
        public int? ConditionId { get; set; }
        public Condition? Condition { get; set; }
    }
}

