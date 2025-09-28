using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.CognitiveLoadJail.Entities
{
    public class GroupEPNote : LocalizedNote
    {
        public required int GroupEPId { get; set; }
        public required GroupEP GroupEP { get; set; }
    }
}
