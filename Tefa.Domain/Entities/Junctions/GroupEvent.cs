namespace Tefa.Domain.Entities.Junctions
{
    public class GroupEvent
    {
        public required Event Event { get; set; }
        public required int GroupId { get; set; }
        public required Group Group { get; set; }
        public ICollection<GroupEventNote> Notes { get; set; } = [];
    }
}
