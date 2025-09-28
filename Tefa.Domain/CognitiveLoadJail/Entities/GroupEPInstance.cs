using Tefa.Domain.Entities;
using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.CognitiveLoadJail.Entities
{
    public class GroupEPInstance : Instance
    {
        public required int GroupInsstanceId { get; set; }
        public required GroupInst GroupInstance { get; set; }
        public required int EventInstanceId { get; set; }
        public required EventInstance EventInstance { get; set; }
    }
}
