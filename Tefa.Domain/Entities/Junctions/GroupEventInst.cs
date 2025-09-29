using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    public class GroupEventInst : Instance
    {
        public required int GroupInsstanceId { get; set; }
        public required GroupInst GroupInstance { get; set; }
        public required int EventInstanceId { get; set; }
        public required EventInst EventInstance { get; set; }
    }
}
