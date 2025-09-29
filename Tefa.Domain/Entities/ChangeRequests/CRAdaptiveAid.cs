
using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.ChangeRequests
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class CRAdaptiveAid : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public AdaptiveAid? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public AdaptiveAidInst? EntityInstance {  get; set; }
    }
}

