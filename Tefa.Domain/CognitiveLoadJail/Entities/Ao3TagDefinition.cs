using Tefa.Domain.CognitiveLoadJail.Entities.FandomCore.Locations;
using Tefa.Domain.CognitiveLoadJail.Enums.Community;
using Tefa.Domain.Entities;
using Tefa.Domain.Enums;

namespace Tefa.Domain.CognitiveLoadJail.Entities
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
        public ICollection<Media> Media { get; set; } = [];
        public ICollection<Character> Characters { get; set; } = [];
        public ICollection<GenderSysTag> GendersSysTags { get; set; } = [];
        public ICollection<OrientationSysTag> OrientationSysTags { get; set; } = [];
        public ICollection<Species> Species { get; set; } = [];
        public ICollection<Relationship> Relationships { get; set; } = [];
        public ICollection<Location> Locations { get; set; } = [];
    }
}
