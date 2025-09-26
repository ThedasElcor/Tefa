using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.Community.CommunityEvents
{
    public class CommunityEventName : LocalizedName
    {
        public required int CommunityEventId { get; set; }
        public required CommunityEvent CommunityEvent { get; set; }
    }
}
