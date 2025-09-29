namespace Tefa.Domain.Entities.Junctions
{
    public class CharacterEvent
    {
        public required int Id { get; set; }
        public required int CharacterId { get; set; }
        public required Character Character { get; set; }
        public required int EventId { get; set; }
        public required Event Event { get; set; }
        public ICollection<CharacterEventNote> Notes { get; set; } = [];
    }
}
