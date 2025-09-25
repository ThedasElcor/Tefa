
using Tefa.Domain.Entities.FandomCore.Events;
using Tefa.Domain.Entities.FandomCore.Groups;
using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.EventParticipants
{
    public class GroupEPInstance : Instance
    {
        public required int GroupInsstanceId { get; set; }
        public required GroupInstance GroupInstance { get; set; }
        public required int EventInstanceId { get; set; }
        public required EventInstance EventInstance { get; set; }
    }
}
