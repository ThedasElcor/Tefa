using Tefa.Domain.Entities.Tags;

namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class AdaptiveAid
    {
        public required int Id { get; set; }
        public ICollection<AdaptiveAidName> Names { get; set; } = [];
        public ICollection<AdaptiveAidNote> Notes { get; set; } = [];
        public ICollection<Character> UsedBy { get; set; } = [];
        public ICollection<AdaptiveAidAcessibilityTag> AcessibilityTags { get; set;} = [];
        public ICollection<AdaptiveAidFunctionTag> FunctionTags { get; set; } = [];
        public ICollection<AdaptiveAidModalityTag> ModalityTags { get; set; } = [];
        public ICollection<AdaptiveAidTypeTag> TypeTags { get; set; } = [];
    }
}

