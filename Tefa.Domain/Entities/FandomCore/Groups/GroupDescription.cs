using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.Groups
{
    public class GroupDescription : LocalizedNote
    {
        public required int GroupId { get; set; }
        public required Group Group { get; set; }
    }
}
