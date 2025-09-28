using Tefa.Domain.CognitiveLoadJail.Entities;
using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community.Collections;
using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community.CommunityEvents;
using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Users;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community
{
    public class Community
    {
        public required int Id { get; set; }
        public ICollection<CommunityName> CommunityNames { get; set; } =  []; //Can be localized for multilingual communities
        public ICollection<CommunityLanguage> CommunityLanguages { get; set; } = [];
        public ICollection<CommunityDescription> CommunityDescriptions { get; set; } = [];
        public ICollection<CommunityLink> CommunityLinks { get; set; } = [];

        public ICollection<Fandom> CommunityFandoms { get; set; } = [];
        public ICollection<CommunityEvent> CommunityEvents { get; set; } = [];
        public ICollection<Collection> NonEventCollections { get; set; } = []; //For collections not part of a Community Event

        //Membership
        public ICollection<ApplicationUser> Admins { get; set; } = [];
        public ICollection<ApplicationUser> Moderators { get; set; } = [];
        public ICollection<ApplicationUser> Members { get; set; } = [];

       
    }
}
