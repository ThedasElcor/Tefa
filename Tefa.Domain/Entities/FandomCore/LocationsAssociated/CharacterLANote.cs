using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.LocationsAssociated
{
    public class CharacterLANote : LocalizedNote
    {
        public required int CharacterLAId { get; set; }
        public required CharacterLA CharacterLA { get; set; }
    }
}
