using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Entities.FandomCore.Events;
using Tefa.Domain.Entities.FandomCore.Groups;
using Tefa.Domain.Entities.FandomCore.Locations;
using Tefa.Domain.Entities.FandomCore.Relationships;
using Tefa.Domain.Enums.Community;

namespace Tefa.Domain.Entities.Community.CommunityEvents
{
    public class CommunityEventRequest
    {
        public required int Id { get; set; }
        public required int FandomEventInstanceId { get; set; }
        public required CommunityEventInstance FandomEventInstance { get; set; }
        public required int SignUpId { get; set; }
        public required CommunityEventSignUp SignUp { get; set; }
        public string? AdminNotes { get; set; }

        //Request Content
        public bool AllowExplicit { get; set; }
        public bool AllowTreat { get; set; }
        public CommunityEventTransactionType RequestType {  get; set; }
        public int InstanceId { get; set; }
        public string? FreeformRequest {  get; set; }
        public CharacterInstance? Character {  get; set; }
        public EventInstance? Event { get; set; }
        public GroupInstance? Group { get; set; }
        public LanguageInstance? Language { get; set; }
        public LocationInstance? Location { get; set; }
        public RelationshipInstance? Relationship { get; set; }
        public string RequestNotes { get; set; } = string.Empty;
    }
}
