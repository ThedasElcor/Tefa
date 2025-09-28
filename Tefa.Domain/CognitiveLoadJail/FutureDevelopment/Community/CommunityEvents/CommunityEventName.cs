using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community.CommunityEvents
{
    public class CommunityEventName : LocalizedName
    {
        public required int CommunityEventId { get; set; }
        public required CommunityEvent CommunityEvent { get; set; }
    }
}
