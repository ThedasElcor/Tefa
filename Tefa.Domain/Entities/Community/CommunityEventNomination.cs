using Tefa.Domain.Entities.FandomCore;
using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Entities.FandomCore.Events;
using Tefa.Domain.Entities.FandomCore.Groups;
using Tefa.Domain.Entities.FandomCore.Locations;
using Tefa.Domain.Entities.FandomCore.Relationships;
using Tefa.Domain.Entities.Users;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Events
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
        public EventInstance? Event { get; set; }
        public GroupInstance? Group { get; set; }
        public LanguageInstance? Language { get; set; }
        public LocationInstance? Location { get; set; }
        public RelationshipInstance? Relationship { get; set; }

        //Metadata
        // Submitter metadata
        public string SubmittedBy { get; set; } = string.Empty; //UserName or Non-User String
        public ApplicationUser? UserSubmitted { get; set; }
        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;

        // Moderation and lifecycle
        /*Note to self: break out moderation metadata into a seperate log */
        public Status Status { get; set; } = Status.Pending;
        public string? ModeratorNotes { get; set; }
        public DateTime? ReviewedAt { get; set; }

    }
}
