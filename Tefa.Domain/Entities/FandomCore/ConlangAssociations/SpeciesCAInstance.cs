using Tefa.Domain.Entities.FandomCore.Conlangs;
using Tefa.Domain.Entities.FandomCore.Species;
using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.ConlangAssociations
{
    public class SpeciesCAInstance : Instance
    {
        public required int SpeciesId { get; set; }
        public required SpeciesInstance Species {  get; set; }
        public required int ConlangId { get; set; }
        public required ConlangInstance Conlang { get; set; }
    }
}
