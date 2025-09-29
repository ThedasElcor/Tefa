using Tefa.Domain.Entities.Abstract;
using Tefa.Domain.Entities.Junctions;
using Tefa.Domain.Entities.Tags;

namespace Tefa.Domain.Entities
{
    public class SpeciesInst : Instance
    {
        public required int SpeciesId { get; set; }
        public required SpeciesInst Species { get; set; }
        
        //Tags
        public ICollection<SpeciesFormTag> FormTags { get; set; } = [];
        public ICollection<SpeciesOriginTag> OriginTags { get; set; } = [];

        // Navigation Properties
        public ICollection<CharacterSpeciesInst> AssociatedCharacters { get; set; } = [];
        public ICollection<SpeciesLanguageInst> AssociatedLanguages { get; set; } = [];
        public ICollection<SpeciesEventInst> AssoiciatedEvents { get; set; } = [];
    }
}
