using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.Characters
{
    public class CharacterName : LocalizedName
    {
         public required int CharacterId { get; set; }
        public required Character Character { get; set; } 
    }
}
