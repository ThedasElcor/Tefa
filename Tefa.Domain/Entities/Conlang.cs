using Tefa.Domain.Entities.Junctions;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class Conlang
    {
        public required int Id { get; set; }
        public Fandom OriginalFandom { get; set; } // Use IRL as needed
        public string? SysName { get; set; } //For administrative convenience, use Names to suppost localization and variants
        public ICollection<ConlangName> Names { get; set; } = [];
        public ICollection<ConlangNote> Notes { get; set; } = [];
        
        public ICollection<GroupLanguage> AssociatedGroups { get; set; } = [];
        public ICollection<LanguageLocation> AssociatedLocations { get; set; } = [];
        public ICollection<SpeciesLanguage> AssociatedSpecies {  get; set; } = [];
        
    }
}
