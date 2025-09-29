using Tefa.Domain.Entities.Abstract;
using Tefa.Domain.Entities.Junctions;

namespace Tefa.Domain.Entities.ChangeRequests
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class CRSpeciesLanguage : ChangeRequest
    {
        public int? ExistingEntityId { get; set; }
        public SpeciesLocation? ExistingEntity { get; set; }
        public int? EntityInstanceId { get; set; }
        public SpeciesLocationInst? EntityInstance { get; set; }
    }
}
