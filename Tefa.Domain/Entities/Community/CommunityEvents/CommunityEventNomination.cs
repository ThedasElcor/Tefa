using Tefa.Domain.Entities.ChangeRequests;
using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Entities.FandomCore.Conlangs;
using Tefa.Domain.Entities.FandomCore.Events;
using Tefa.Domain.Entities.FandomCore.Groups;
using Tefa.Domain.Entities.FandomCore.Locations;
using Tefa.Domain.Entities.FandomCore.Relationships;
using Tefa.Domain.Entities.FandomCore.Species;
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
        public CharacterInstance? Character { get; set; }
        public ConlangInstance? Conlang { get; set; }
        public EventInstance? Event { get; set; }
        public GroupInstance? Group { get; set; }
        public LocationInstance? Location { get; set; }
        public RelationshipInstance? Relationship { get; set; }
        public SpeciesInstance? Species { get; set; }

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
