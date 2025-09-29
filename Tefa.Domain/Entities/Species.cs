using Tefa.Domain.Entities.Junctions;
using Tefa.Domain.Entities.Tags;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities
{
    public class Species
    {
        #region Watermark
        /*  Thedas Elcor's Fandom App (TEFA)
        *   [With bashful pride] Only my engine thinks about Fandom like we do.
        *   https://github.com/ThedasElcor/Tefa */
        #endregion
        public required int Id { get; set; }
        public Fandom? OriginalFandomId { get; set; } //Use "IRL (1)" for non-specific species like "Human"
        public FandomTag? OriginalFandom { get; set; }
        public ICollection<SpeciesName> Names { get; set; } = [];
        public ICollection<SpeciesNote> Notes { get; set; } = [];

        //Tags
        public ICollection<SpeciesFormTag> FormTags { get; set; } = [];
        public ICollection<SpeciesOriginTag> OriginTags { get; set; } = [];
        public ICollection<SexStructureTag> SexStructures { get; set; } = [];


        // Navigation Properties
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
        public ICollection<Character> AssociatedCharacters { get; set; } = [];
        public ICollection<SpeciesLanguage> AssociatedLanguages { get; set; } = [];
        public ICollection<SpeciesGroup> AssociatedGroups { get; set; } = [];
        public ICollection<SpeciesEvent> AssoiciatedEvents { get; set; } = [];
        public ICollection<FandomTag> Fandoms { get; set; } = [];

        //For species with multiple variants like elves or dwarves
        public Species? RootVariant { get; set; }
        public ICollection<SpeciesVariantLink> VariantOf { get; set; } = [];
        public ICollection<SpeciesVariantLink> Variants { get; set; } = [];
        public ICollection<Species> ConfirmedDistinctFrom { get; set; } = []; //For uniqueness verification utility
    }
}
