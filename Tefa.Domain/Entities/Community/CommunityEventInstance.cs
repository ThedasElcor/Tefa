using Tefa.Domain.Entities.Community;

namespace Tefa.Domain.Entities.Events
{
    public class CommunityEventInstance
    {
        public required int Id { get; set; }
        public required int FandomEventId { get; set; }
        public required CommunityEvent FandomEvent { get; set; }
        public Tagset? Tagset { get; set; }
        public Collection? Collection { get; set; } 
        public string InstanceName { get; set; } = string.Empty; // e.g. "2023", "Winter 2024"
        public string? InstanceUrl { get; set; } // e.g. URL to event page
        public string? MetadataKey { get; set; }
        public string? MetadataJson { get; set; }

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
        public ICollection<CommunityEventAssignment> Assignments { get; set; } = [];
        public ICollection<FanWork> FanWorks { get; set; } = [];
        public ICollection<CommunityEventNomination> Nominations { get; set; } = [];
        public ICollection<CommunityEventOffer> Offers { get; set; } = [];
        public ICollection<CommunityEventRequest> Requests { get; set; } = [];
        public ICollection<CommunityEventSignUp> SignUps { get; set; } = [];
    }
}
