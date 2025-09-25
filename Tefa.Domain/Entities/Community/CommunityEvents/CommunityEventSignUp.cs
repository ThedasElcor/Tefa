namespace Tefa.Domain.Entities.Community.CommunityEvents
{
    public class CommunityEventSignUp
    {
        public required int Id { get; set; }
        public required int FandomEventInstanceId { get; set; }
        public required CommunityEventInstance FandomEventInstance { get; set; }
        public ICollection<CommunityEventOffer> Offers { get; set; } = [];
        public ICollection<CommunityEventRequest> Requests { get; set; } = [];
        public required string SignUpInfo { get; set; } // Json payload of sign up data, customizable by exchange
        public string? AdminNotes { get; set; }
    }
}
