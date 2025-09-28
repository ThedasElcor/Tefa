using Tefa.Domain.CognitiveLoadJail.Entities;
using Tefa.Domain.CognitiveLoadJail.Entities.FandomCore.Locations;
using Tefa.Domain.CognitiveLoadJail.Enums.Community;
using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community.Collections;
using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community.CommunityEvents;
using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Users;
using Tefa.Domain.Entities;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community
{
    public class FanWork
    {
        public required int Id { get; set; }
        public ApplicationUser? User { get; set; } //Not requiring folks to sign up at this time
        public Creator? Creator { get; set; } //Not tracked for all exchanges
        public string? FanWorkData { get; set; } // Json payload for title, summary, warnings, etc
        public bool IsComplete { get; set; } = true; //Incomplete works not currently ebing tracked, but good option to have
        public string? Url { get; set; }

        // Navigation properties
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
        public ICollection<ConLang> Languages { get; set; } = [];
        public ICollection<FanWorkType> FanWorkTypes { get; set; } = [];

        // Fandoms, Subfandoms, and Media
        public ICollection<Fandom> Fandoms { get; set; } = [];
        public ICollection<Media> Media { get; set; } = [];

        // Events and Collections
        public ICollection<CommunityEventInstance> FandomEventInstances { get; set; } = [];
        public ICollection<Collection> Collections { get; set; } = [];

        // Characters
        public ICollection<Character> Characters { get; set; } = [];
        public ICollection<CharacterInst> CharacterInstances { get; set; } = [];
        
        //Locations
        public ICollection<Location> Locations { get; set; } = [];
        public ICollection<LocationInstance> LocationInstances { get; set; } = [];
        
        // Relationships
        public ICollection<Relationship> Relationships { get; set; } = [];
        public ICollection<RelationshipInst> RelationshipInstances { get; set; } = [];
        
        //Species
         public ICollection<Species> Species { get; set; } = [];
    }
}
