using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class RelationshipInst : Instance
    {
        public required int RelationshipId { get; set; } 
        public required Relationship Relationship { get; set; }
        public ICollection<CharacterInst> Characters { get; set; } = [];
    }
}
