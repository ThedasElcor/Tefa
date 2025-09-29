using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    public class CharacterEventInst : Instance
    {
        public required int CharacterId { get; set; }
        public required CharacterInst Character { get; set; }
        public required int EventId { get; set; }
        public required EventInst Event { get; set; }
    }
}
