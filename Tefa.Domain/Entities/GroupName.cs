using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities
{
    public class GroupName : LocalizedName
    {
        public required int GroupId { get; set; }
        public required Group Group { get; set; }
    }
}
