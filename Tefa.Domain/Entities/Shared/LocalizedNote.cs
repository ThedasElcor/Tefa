namespace Tefa.Domain.Entities.Shared
{
    public abstract class LocalizedNote
    {
        public required int Id { get; set; }
        public required string Lang { get; set; }   // ISO standardized language code
        public string Text { get; set; } = string.Empty;
    }
}
