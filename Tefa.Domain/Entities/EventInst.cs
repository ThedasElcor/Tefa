using Tefa.Domain.Entities.Abstract;
using Tefa.Domain.Entities.Junctions;

namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class EventInst : Instance
    {
        // Instance of
        public required int EventId { get; set; }
        public required Event Event { get; set; }

        // Instance Information
        public ICollection<EventLocationInst> AssociatedLocations { get; set; } = [];
        public ICollection<CharacterEventInst> AssociatedCharacters { get; set; } = [];
        public ICollection<GroupEventInst> AssociatedGroups {  get; set; } = [];
        public ICollection<SpeciesGroupInst> AssociatedSpecies { get; set; } = [];
    }
}
