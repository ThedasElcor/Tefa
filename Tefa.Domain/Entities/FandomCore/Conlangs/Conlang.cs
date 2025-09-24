using Tefa.Domain.Entities.FandomCore.Groups;
using Tefa.Domain.Entities.FandomCore.Locations;
using Tefa.Domain.Entities.FandomCore.Species;
using Tefa.Domain.Entities.MetadataCore.Fandoms;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.Conlangs
{
    public class Conlang
    {
        public required int Id { get; set; }
        public string? SysName { get; set; } //For administrative convenience, use Names to supposr localization and variants
        public ICollection<ConlangName> Names { get; set; } = [];
        public FandomId? OriginalFandom { get; set; }
        public ICollection<Fandom> Fandoms { get; set; } = [];
        public ICollection<Group> AssociatedGroups { get; set; } = [];
        public ICollection<Location> AssociatedLocations { get; set; } = [];
        public ICollection<SpeciesItem> AssociatedSpecies {  get; set; } = [];
    }
}
