using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Events
{
    public class CommunityEventMatch
    {
        public required int Id { get; set; }
        public required int FandomEventInstanceId { get; set; }
        public required int OfferId { get; set; }
        public required CommunityEventOffer Offer { get; set; }
        public required int RequestId { get; set; }
        public required CommunityEventRequest Request { get; set; }
        public Status Status { get; set; } = Status.Pending;
        public string? AdminNotes { get; set; }

    }
}
