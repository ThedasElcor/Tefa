using Tefa.Domain.Entities.Ao3Tags;
using Tefa.Domain.Entities.Characters;
using Tefa.Domain.Entities.ConLangs;
using Tefa.Domain.Entities.Events;
using Tefa.Domain.Entities.Groups;
using Tefa.Domain.Entities.Locations;
using Tefa.Domain.Entities.Media;
using Tefa.Domain.Entities.Species;

using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Fandoms
{
    public class Fandom
    {
        public required FandomId Id { get; set; }
        public Fandom? ParentFandom { get; set; }
        public ICollection<Fandom> Subfandoms { get; set; } = [];
        public required string Name { get; set; } 
        public bool IncludeGeneric { get; set; } = false; // Whether to include generic/real world tags for this fandom
        public bool FullySupported { get; set; } = false; // True for Core Fandoms, false for crossover support

        // Navigation properties
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
        public ICollection<Character> Characters { get; set; } = [];
        public ICollection<ConLang> ConLangs { get; set; } = [];
        public ICollection<Event> Events { get; set; } = [];
        public ICollection<Group> Groups { get; set; } = [];
        public ICollection<Location> Locations { get; set; } = [];
        public ICollection<MediaItem> Media { get; set; } = [];
        public ICollection<SpeciesItem> Species { get; set; } = [];
       
    }
}
