using Tefa.Domain.CognitiveLoadJail.Entities;
using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community;
using Tefa.Domain.Entities.Tags;

namespace Tefa.Domain.Entities.Abstract
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public abstract class Instance
    {
        public required int Id { get; set; }
        public ICollection<LanguageTag> LanguageTags { get; set; } = []; // What language(s) is this instance written in

        public ICollection<FanWork> FanWorks { get; set; } = [];
        public ICollection<Fandom> AuTags { get; set; } = []; // Only tag fandoms that aren't inherited from the parent class.

        public bool CanonicalUse { get; set; } = true; // True if used as in canon, false if AU or altered
        public string? InstanceName { get; set; }
        public string? FreeformNotes { get; set; }
    }
}
