using Tefa.Domain.Entities.Abstract;
using Tefa.Domain.Entities.Tags;

namespace Tefa.Domain.Entities.ChangeRequests
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class CRFandom : ChangeRequest
    {
        public int? ExistingEntityId {  get; set; }
        public FandomTag? ExistingEntity { get; set; }
    }
}
