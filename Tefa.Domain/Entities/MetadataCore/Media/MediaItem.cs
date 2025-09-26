using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Entities.MetadataCore.Ao3Tags;
using Tefa.Domain.Entities.MetadataCore.Fandoms;
using Tefa.Domain.Entities.MetadataCore.MediaAppearances;

namespace Tefa.Domain.Entities.MetadataCore.Media
{
    public class MediaItem
    {
        public Guid Id { get; set; }
        public ICollection<MediaName> Names { get; set; } = [];
        public ICollection<MediaRelease> Releases { get; set; } = [];

        // Navigation properties
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
         public ICollection<FandomMedia> Fandoms { get; set; } = [];
        public ICollection<CharacterMA> CharacterAppearances { get; set; } = [];
        public ICollection<EventMA> EventAppearances { get; set; } = [];
        public ICollection<GroupMA> GroupAppearances { get; set; } = [];
        public ICollection<LocationMA> LocationAppearances { get; set; } = [];
        public ICollection<RelationshipMA> RelationshipAppearances { get; set; } = [];
        public ICollection<SpeciesMA> SpeciesAppearances { get; set; } = [];
       

        // Component Media (DAG)
        public int? RootComponentId {  get; set; }
        public ICollection<MediaComponentLinks> ComponentOf { get; set; } = [];
        public ICollection<MediaComponentLinks> Contains {  get; set; } = [];
    }
}
