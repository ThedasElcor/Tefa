using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    public class GroupEventNote : LocalizedNote
    {
        public required int GroupEventId { get; set; }
        public required GroupEvent GroupEvent { get; set; }
    }
}
