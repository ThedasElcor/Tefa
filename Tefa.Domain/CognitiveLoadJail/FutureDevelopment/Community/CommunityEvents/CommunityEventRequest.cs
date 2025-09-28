using Tefa.Domain.CognitiveLoadJail.Entities;
using Tefa.Domain.CognitiveLoadJail.Entities.FandomCore.Locations;
using Tefa.Domain.CognitiveLoadJail.Enums.Community;
using Tefa.Domain.Entities;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community.CommunityEvents
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
        public CharacterInst? Character {  get; set; }
        public EventInstance? Event { get; set; }
        public GroupInst? Group { get; set; }
        public LanguageInstance? Language { get; set; }
        public LocationInstance? Location { get; set; }
        public RelationshipInst? Relationship { get; set; }
        public string RequestNotes { get; set; } = string.Empty;
    }
}
