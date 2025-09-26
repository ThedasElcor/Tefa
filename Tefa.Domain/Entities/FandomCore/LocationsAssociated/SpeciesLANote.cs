using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.LocationsAssociated
{
    public class SpeciesLANote : LocalizedNote
    {
        public required int SpeciesLAId { get; set; }
        public required SpeciesLA SpeciesLA { get; set; }
    }
}
