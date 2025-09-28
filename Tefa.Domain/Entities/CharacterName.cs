using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities
{
    public class CharacterName : LocalizedName
    {
         public required int CharacterId { get; set; }
        public required Character Character { get; set; } 
    }
}
