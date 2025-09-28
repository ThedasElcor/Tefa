
using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class RelationshipNote : LocalizedNote
    {
        public required int RelationshipId { get; set; }
        public Relationship Relationship { get; set; }
    }
}

