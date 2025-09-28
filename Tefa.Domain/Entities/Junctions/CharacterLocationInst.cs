using Tefa.Domain.CognitiveLoadJail.Entities.FandomCore.Locations;
using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class CharacterLocationInst : Instance
    {
        public required int CharacterId { get; set; }
        public required Character Character { get; set; }
        public required int LocationId { get; set; }
        public required Location Location { get; set; }
    }
}
