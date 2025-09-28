using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community;
using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community.Collections;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community.CommunityEvents
{
    public class CommunityEventInstance
    {
        public required int Id { get; set; }
        public required int CommunityId { get; set; }
        public required Community Community { get; set; }
        public ICollection<Community> GuestCommunities { get; set; } = []; //For cross-community events
        public required int CommunityEventId { get; set; }
        public required CommunityEvent CommunityEvent { get; set; }
        
        public ICollection<CommunityEventName> EventInstanceNames { get; set; } = []; // e.g. "2023", "Winter 2024"
        public ICollection<CommunityLink> EventInstanceLinks { get; set; } = []; // e.g. URL to event page
        

        // Event Dates
        public DateTime? NominationStart { get; set; }
        public DateTime? NominationEnd { get; set; }
        public DateTime? SignUpStart { get; set; }
        public DateTime? SignUpEnd { get; set; }
        public DateTime? AssignmentDate { get; set; }
        public DateTime? WorkDueDate { get; set; }
        public DateTime? WorkReveals { get; set; }
        public DateTime? AuthorReveals { get; set; }

        // Navigation Properties
        public ICollection<CommunityEventNomination> Nominations { get; set; } = [];
        public ICollection<Tagset> EligibleTagsets { get; set; } = [];
        public ICollection<CommunityEventSignUp> SignUps { get; set; } = [];
        public ICollection<CommunityEventOffer> Offers { get; set; } = [];
        public ICollection<CommunityEventRequest> Requests { get; set; } = [];
        public ICollection<CommunityEventAssignment> Assignments { get; set; } = [];
        public ICollection<CommunityEventPinchHits> PinchHits { get; set; } = [];

        public ICollection<FanWork> FanWorks { get; set; } = [];
        public required Collection EventInstanceCollection { get; set; } = [];
        
    }
}
