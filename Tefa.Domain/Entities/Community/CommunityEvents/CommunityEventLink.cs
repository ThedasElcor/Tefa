using Tefa.Domain.Entities;
using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities.Community.CommunityEvents
{
    public class CommunityEventLink : Link
    {
        public required int EventId { get; set; }
        public required Event Event { get; set; }
    }
}
