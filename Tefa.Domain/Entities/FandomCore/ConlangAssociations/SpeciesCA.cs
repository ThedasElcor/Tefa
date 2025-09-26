using Tefa.Domain.Entities.FandomCore.Conlangs;
using Tefa.Domain.Entities.FandomCore.Species;

namespace Tefa.Domain.Entities.FandomCore.ConlangAssociations
{
    public class SpeciesCA
    {
        public required int SpeciesId { get; set; }
        public required SpeciesItem Species { get; set; }
        public required int ConlangId { get; set; }
        public required Conlang Conlang { get; set; }
    }
}
