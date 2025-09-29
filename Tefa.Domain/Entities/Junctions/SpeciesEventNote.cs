using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    public class SpeciesEventNote : LocalizedNote
    {
        public required int SpeciesSPId { get; set; }
        public required SpeciesEvent SpeciesEP { get; set; }
    }
}
