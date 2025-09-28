using Tefa.Domain.Entities.Abstract;
using Tefa.Domain.Entities.Tags;

namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class AdaptiveAidInst : Instance
    {
        public int? AdaptiveAidId { get; set; }
        public AdaptiveAid? AdaptiveAid { get; set; }
        public ICollection<CharacterInst> UsedBy { get; set; } = [];
        public ICollection<AdaptiveAidAcessibilityTag> AcessibilityTags { get; set; } = [];
        public ICollection<AdaptiveAidFunctionTag> FunctionTags { get; set; } = [];
        public ICollection<AdaptiveAidModalityTag> ModalityTags { get; set; } = [];
        public ICollection<AdaptiveAidTypeTag> TypeTags { get; set; } = [];
    }
}
}

