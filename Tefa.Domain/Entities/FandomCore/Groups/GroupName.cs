namespace Tefa.Domain.Entities.FandomCore.Groups
{
    public class GroupName
    {
        public required int Id { get; set; }
        public required string Lang { get; set; }   // ISO standardized language code
        public bool IsPreferred { get; set; } // Is this the main name in this language?
        public required int GroupId { get; set; }
        public required Group Group { get; set; }
        public required string Name { get; set; }
        public string? Notes { get; set; }
    }
}
