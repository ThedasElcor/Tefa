using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    public class GroupLocationInst : Instance
    {
        public required int GroupId { get; set; }
        public required GroupInst Group { get; set; }
        public required int LocationId { get; set; }
        public required Location Location { get; set; }
    }
}
