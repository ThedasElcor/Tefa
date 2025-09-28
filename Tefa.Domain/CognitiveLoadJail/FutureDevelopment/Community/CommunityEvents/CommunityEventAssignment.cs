using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community.CommunityEvents
{
    public class CommunityEventAssignment
    {
      
            public required int Id { get; set; }

            // Anchoring
            public required int FandomEventInstanceId { get; set; }
            public required CommunityEventInstance FandomEventInstance { get; set; }

            public required int CreatorSignUpId { get; set; }
            public required CommunityEventSignUp CreatorSignUp { get; set; }
            public required int RecipientSignUpId { get; set; }
             public required CommunityEventSignUp RecipientSignUp { get; set; }

            // Matching context
             public ICollection<CommunityEventRequest> RecipientRequests { get; set; } = [];

            // Fulfillment metadata
           public string? CreatorContact { get; set; } // e.g. email or AO3 username
           public bool IsNotified { get; set; } = false;
           public bool IsComplete { get; set; } = false;
           public DateTime? DefaultDate { get; set; } // Date to warn admins to seek pinch hitter if not complete
            public bool Defaulted { get; set; } = false;
            public int? PinchHitId { get; set; }
            public int? FanWorkId { get; set; }
            public FanWork? Work { get; set; } // e.g. AO3 URL
      
            // Admin support
            public string? AdminNotes { get; set; }
    }
}
