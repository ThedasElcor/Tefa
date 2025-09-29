using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities
{
    public class ConlangInst : Instance
    {
        public int? ConlangId { get; set; }
        public Conlang? Conlang { get; set; }
        public ICollection<GroupInst> AssociatedGroups { get; set; } = [];
        public ICollection<LocationInst> AssociatedLocations { get; set; } = [];
        public ICollection<SpeciesInst> AssociatedSpecies { get; set; } = [];
    }
}
