using Tefa.Domain.Entities.Abstract;
using Tefa.Domain.Entities.Junctions;
using Tefa.Domain.Entities.Tags;

namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class SpeciesInst : Instance
    {
        public required int SpeciesId { get; set; }
        public required Species Species { get; set; }
        
        //Tags
        public ICollection<SpeciesFormTag> FormTags { get; set; } = [];
        public ICollection<SpeciesOriginTag> OriginTags { get; set; } = [];

        // Navigation Properties
        public ICollection<CharacterInst> AssociatedCharacters { get; set; } = [];
        public ICollection<SpeciesLanguageInst> AssociatedLanguages { get; set; } = [];
        public ICollection<SpeciesEventInst> AssoiciatedEvents { get; set; } = [];
    }
}
