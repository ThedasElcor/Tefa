using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    public class SpeciesGroupInst : Instance
    {
        public required int SpeciesInstanceId { get; set; }
        public required SpeciesInst Species {  get; set; }
        public required int GroupInstanceId { get; set; }
        public required GroupInst Group { get; set; }
    }
}
