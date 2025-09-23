namespace Tefa.Domain.Entities.FandomCore.Characters
{
    public class DisabilityName
    {
        public required int Id { get; set; }
        public required string Lang { get; set; }   // ISO standardized language code
        public bool IsPreferred { get; set; } // Is this the main name in this language?
        public required int CharacterId { get; set; }
        public required Character Character { get; set; }
        public required string Name { get; set; }
        public string? Notes { get; set; }
    }
}
