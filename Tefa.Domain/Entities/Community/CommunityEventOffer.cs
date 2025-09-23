using Tefa.Domain.Entities.Characters;
using Tefa.Domain.Entities.FandomCore;
using Tefa.Domain.Entities.Groups;
using Tefa.Domain.Entities.Locations;
using Tefa.Domain.Entities.Relationships;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Events
{
    public class CommunityEventOffer
    {
            public required int Id { get; set; }
            public required int FandomEventInstanceId { get; set; }
            public required CommunityEventInstance FandomEventInstance { get; set; }
            public required int SignUpId { get; set; }
            public required CommunityEventSignUp SignUp { get; set; }
            public string? AdminNotes { get; set; }

            //Offer Content    
            public bool OfferExplicit { get; set; }
            public CommunityEventTransactionType OfferType { get; set; }
            public int InstanceId { get; set; }
            public string? FreeformRequest { get; set; }
            public CharacterInstance? Character { get; set; }
            public EventInstance? Event { get; set; }
            public GroupInstance? Group { get; set; }
            public LanguageInstance? Language { get; set; }
            public LocationInstance? Location { get; set; }
            public RelationshipInstance? Relationship { get; set; }
            public string OfferNotes { get; set; } = string.Empty;
    }
}
