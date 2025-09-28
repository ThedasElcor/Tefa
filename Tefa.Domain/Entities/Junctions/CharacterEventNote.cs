using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    public class CharacterEventNote : LocalizedNote
    {
        public required int CharacterEPId { get; set; }
        public required CharacterEvent CharacterEP { get; set; }
    }
}
