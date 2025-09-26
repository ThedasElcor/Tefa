using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.EventParticipants
{
    public class GroupEPNote : LocalizedNote
    {
        public required int GroupEPId { get; set; }
        public required GroupEP GroupEP { get; set; }
    }
}
