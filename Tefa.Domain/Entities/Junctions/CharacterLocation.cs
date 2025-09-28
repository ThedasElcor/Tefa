using Tefa.Domain.CognitiveLoadJail.Entities.FandomCore.Locations;

namespace Tefa.Domain.Entities.Junctions
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class CharacterLocation
    {
        public required int Id { get; set; }
        public required int CharacterId { get; set; }
        public required Character Character {  get; set; }
        public required int LocationId { get; set; }
        public required Location Location { get; set; }
        public ICollection<CharacterLocationNote> Notes { get; set; } = [];
    }
}
