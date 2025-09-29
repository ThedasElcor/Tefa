using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Junctions
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class CharacterGroupInst : Instance
    {
        public required int CharacterInstanceId { get; set; }
        public required CharacterInst CharacterInstance { get; set; }
        public required int GroupInstanceId { get; set; }
        public required GroupInst GroupInstance { get; set; }
    }
}
