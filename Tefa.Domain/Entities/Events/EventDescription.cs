namespace Tefa.Domain.Entities.Events
{
    public class EventDescription
    {
        public required int Id { get; set; }
        public required string Lang { get; set; } // ISO standardized language code
        public bool IsPreferred { get; set; } // Is this the main description in this language?
        public required int EventId { get; set; }
        public required Event Event { get; set; }
        public required string Description { get; set; }
        public string? Notes { get; set; }
    }
}
