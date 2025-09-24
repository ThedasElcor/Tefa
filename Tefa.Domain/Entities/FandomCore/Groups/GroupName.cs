using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.Groups
{
    public class GroupName : LocalizedName
    {
        public required int GroupId { get; set; }
        public required Group Group { get; set; }
    }
}
