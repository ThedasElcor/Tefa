using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities
{
    public class GroupInst : Instance
    {
        public required int GroupId { get; set; }
        public required Group Group { get; set; }
    }
}
