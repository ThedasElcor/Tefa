using Tefa.Domain.Entities.Metadata.MediaAppearances;
using Tefa.Domain.Entities.Tags;

namespace Tefa.Domain.Entities.Metadata
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class Media
    {
        public Guid Id { get; set; }
        public ICollection<MediaName> Names { get; set; } = [];
        public ICollection<MediaRelease> Releases { get; set; } = [];

        // Navigation properties
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
         public ICollection<FandomTag> Fandoms { get; set; } = [];
        public ICollection<CharacterMedia> CharacterAppearances { get; set; } = [];
        public ICollection<EventMedia> EventAppearances { get; set; } = [];
        public ICollection<GroupMedia> GroupAppearances { get; set; } = [];
        public ICollection<LocationMedia> LocationAppearances { get; set; } = [];
        public ICollection<RelationshipMedia> RelationshipAppearances { get; set; } = [];
        public ICollection<SpeciesMedia> SpeciesAppearances { get; set; } = [];
       

        // Component Media (DAG)
        public int? RootComponentId {  get; set; }
        public ICollection<MediaComponentLinks> ComponentOf { get; set; } = [];
        public ICollection<MediaComponentLinks> Contains {  get; set; } = [];
    }
}
