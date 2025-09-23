using Tefa.Domain.Entities.Fandoms;
using Tefa.Domain.Entities.Groups;
using Tefa.Domain.Entities.Locations;
using Tefa.Domain.Entities.Species;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.ConLangs
{
    public class ConLang
    {
        public required int Id { get; set; }
        public string? SysName { get; set; } //For administrative convenience, use Names to supposr localization and variants
        public ICollection<ConLangName> Names { get; set; } = [];
        public FandomId? OriginalFandom { get; set; }
        public ICollection<Fandom> Fandoms { get; set; } = [];
        public ICollection<Group> AssociatedGroups { get; set; } = [];
        public ICollection<Location> AssociatedLocations { get; set; } = [];
        public ICollection<SpeciesItem> AssociatedSpecies {  get; set; } = [];
    }
}
