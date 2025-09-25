using Tefa.Domain.Entities.FandomCore.Groups;
using Tefa.Domain.Entities.FandomCore.Locations;
using Tefa.Domain.Entities.FandomCore.Species;
using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.Conlangs
{
    public class ConlangInstance : Instance
    {
        public ICollection<GroupInstance> AssociatedGroups { get; set; } = [];
        public ICollection<LocationInstance> AssociatedLocations { get; set; } = [];
        public ICollection<SpeciesInstance> AssociatedSpecies { get; set; } = [];
    }
}
