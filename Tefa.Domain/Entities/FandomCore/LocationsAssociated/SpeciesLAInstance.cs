using Tefa.Domain.Entities.FandomCore.Locations;
using Tefa.Domain.Entities.FandomCore.Species;
using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.LocationsAssociated
{
    public class SpeciesLAInstance : Instance
    {
        public required int SpeciesId { get; set; }
        public required SpeciesInstance Species { get; set; }
        public required int AssociatedLocationId { get; set; }
        public required LocationInstance AssociatedLocation {get; set;}
    }
}
