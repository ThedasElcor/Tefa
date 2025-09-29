using Tefa.Domain.CognitiveLoadJail.Entities.FandomCore.Locations;
using Tefa.Domain.Entities;
using Tefa.Domain.Entities.ChangeRequests;
using Tefa.Domain.Entities.Community;
using Tefa.Domain.Entities.Users;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Community.CommunityEvents
{
    public class CommunityEventNomination
    {
        public int Id { get; set; }
        public required Tagset Tagset { get; set; } //Targetted Tagset for the nomination

        //Nomination Content
        public CommunityEventTransactionType NominationType { get; set; }
        public int InstanceId { get; set; }
        public string? FreeformRequest { get; set; }
        public CharacterInst? Character { get; set; }
        public ConlangInst? Conlang { get; set; }
        public EventInst? Event { get; set; }
        public GroupInst? Group { get; set; }
        public LocationInstance? Location { get; set; }
        public RelationshipInst? Relationship { get; set; }
        public SpeciesInst? Species { get; set; }

        //Metadata
        // Submitter metadata
        public string SubmittedBy { get; set; } = string.Empty; //UserName or Non-User String
        public ApplicationUser? UserSubmitted { get; set; }
        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;

        // Moderation and lifecycle
        public Status Status { get; set; } = Status.Pending;
        public ICollection<ReviewEntry> ReviewLog { get; set; } = [];

    }
}
