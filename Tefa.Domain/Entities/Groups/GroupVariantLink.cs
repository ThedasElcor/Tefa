
namespace Tefa.Domain.Entities.Groups
{
    public class GroupVariantLink
    {
        public int GeneralGroupId { get; set; }
        public required Group GeneralGroup { get; set; }
        public int SpecifcGroupId { get; set; }
        public required Group SpecificGroup { get; set; }
        public string? SysNotes { get; set; }
    }
}
