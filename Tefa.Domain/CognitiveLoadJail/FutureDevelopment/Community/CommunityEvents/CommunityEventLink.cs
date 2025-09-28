using Tefa.Domain.CognitiveLoadJail.Entities;
using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community.CommunityEvents
{
    public class CommunityEventLink : Link
    {
        public required int EventId { get; set; }
        public required Event Event { get; set; }
    }
}
