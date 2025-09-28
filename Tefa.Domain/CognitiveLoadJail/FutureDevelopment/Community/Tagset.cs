using System.Text.RegularExpressions;
using Tefa.Domain.CognitiveLoadJail.Entities;
using Tefa.Domain.CognitiveLoadJail.Entities.FandomCore.Locations;
using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.ChangeRequests;
using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community.Collections;
using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community.CommunityEvents;
using Tefa.Domain.Entities;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community
{
    public class Tagset
    {
        public required int Id { get; set; }
        public required int TagsetOwnerId { get; set; }
        public required Community TagsetOwner { get; set; }
        public string? SysNotes { get; set; } // Internal notes about this tagset
        public ICollection<ReviewEntry> TagsetReviewLog { get; set; } = [];
        public string? Description { get; set; }

        //Tag Contents
        public ICollection<Ao3Tag> Ao3Tags { get; set; } = [];
        // Identical Instances can be compiled, but they need to be instances or we couldn't allow anything but canonical uses
        public ICollection<CharacterInst> Characters { get; set; } = []; 
        public bool AllowCharacters { get; set; } // Whether the tagset owner allows character matches
        public ICollection<ConlangInst> Conlangs { get; set; } = [];
        public bool AllowConlangs { get; set; }  // Whether the tagset owner allows conlang matches
        public ICollection<EventInstance> Events { get; set; } = [];
        public bool AllowEvents { get; set; }  // Whether the tagset owner allows event matches
        public ICollection<Group> Groups { get; set; } = [];
        public bool AllowGroups { get; set; }  // Whether the tagset owner allows group matches
        public ICollection<LocationInstance> Locations { get; set; } = [];
        public bool AllowLocations { get; set; } // Whether the tagset owner allows location matches
        public ICollection<RelationshipInst> Relationships { get; set; } = [];
        public bool AllowRelationships { get; set; } // Whether the tagset owner allows relationship matches
        public ICollection<SpeciesInst> Species { get; set; } = [];
        public bool AllowSpecies { get; set; }

        // Can expand to other match types in future

        // Navigation properties
        public ICollection<CommunityEventInstance> FandomEventInstances { get; set; } = [];
        public ICollection<Collection> Collections { get; set; } = [];
    }
}
