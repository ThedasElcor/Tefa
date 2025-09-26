using Tefa.Domain.Entities.FandomCore.Events;
using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.Community.CommunityEvents
{
    public class CommunityEventLink : Link
    {
        public required int EventId { get; set; }
        public required Event Event { get; set; }
    }
}
