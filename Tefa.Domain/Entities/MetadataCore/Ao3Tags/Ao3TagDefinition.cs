using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Entities.FandomCore.Locations;
using Tefa.Domain.Entities.FandomCore.Relationships;
using Tefa.Domain.Entities.FandomCore.Species;
using Tefa.Domain.Entities.MetadataCore.Fandoms;
using Tefa.Domain.Entities.MetadataCore.Media;
using Tefa.Domain.Enums.Admin;
using Tefa.Domain.Enums.Community;

namespace Tefa.Domain.Entities.MetadataCore.Ao3Tags
{
    public class Ao3TagDefinition
    {
        public required int Id { get; set; }
        public required int Ao3Id { get; set; }
        public Ao3TagType? TagTypeId { get; set; }
        public string? Ao3TagLanguage { get; set; }
        public Status DefinitionStatus { get; set; } = Status.Pending;
        public string? SysNotes { get; set; } // Internal notes about this tag
        public ICollection<Fandom> Fandoms { get; set; } = [];
        public ICollection<MediaItem> Media { get; set; } = [];
        public ICollection<Character> Characters { get; set; } = [];
        public ICollection<GenderSysTag> GendersSysTags { get; set; } = [];
        public ICollection<OrientationSysTag> OrientationSysTags { get; set; } = [];
        public ICollection<SpeciesItem> Species { get; set; } = [];
        public ICollection<Relationship> Relationships { get; set; } = [];
        public ICollection<Location> Locations { get; set; } = [];
    }
}
