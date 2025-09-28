using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    public class CharacterLocationNote : LocalizedNote
    {
        public required int CharacterLocationId { get; set; }
        public required CharacterLocation CharacterLocation { get; set; }
    }
}
