using Tefa.Domain.CognitiveLoadJail.Entities.FandomCore.Locations;
using Tefa.Domain.CognitiveLoadJail.Enums;
using Tefa.Domain.Entities;
using Tefa.Domain.Entities.FandomCore.ConLangs;

namespace Tefa.Domain.CognitiveLoadJail.Entities
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
        public ICollection<Conlang> Conlangs { get; set; } = [];
        public ICollection<Event> Events { get; set; } = [];
        public ICollection<Group> Groups { get; set; } = [];
        public ICollection<Location> Locations { get; set; } = [];
        public ICollection<Media> Media { get; set; } = [];
        public ICollection<Species> Species { get; set; } = [];
       
    }
}
