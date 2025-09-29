
using Tefa.Domain.Entities.Abstract;
using Tefa.Domain.Entities.Junctions;

namespace Tefa.Domain.Entities.ChangeRequests
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class CRGroupLanguage : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public GroupLanguage? ExistingEntity {  get; set; }
        public int? EntityInstanceId { get; set; }
        public GroupLanguageInst? EntityInstance { get; set; }
    }
}

