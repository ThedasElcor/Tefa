using Tefa.Domain.Entities.FandomCore;
using Tefa.Domain.Entities.FandomCore.Characters;
using Tefa.Domain.Entities.FandomCore.Conlangs;
using Tefa.Domain.Entities.FandomCore.Events;
using Tefa.Domain.Entities.FandomCore.Groups;
using Tefa.Domain.Entities.FandomCore.Locations;
using Tefa.Domain.Entities.FandomCore.Relationships;
using Tefa.Domain.Entities.FandomCore.Species;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Community.CommunityEvents
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
            public ConlangInstance? Conlang { get; set; }
            public EventInstance? Event { get; set; }
            public GroupInstance? Group { get; set; }
            public LocationInstance? Location { get; set; }
            public RelationshipInstance? Relationship { get; set; }
            public SpeciesInstance? Species { get; set; }
            public string OfferNotes { get; set; } = string.Empty;
    }
}
