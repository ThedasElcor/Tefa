using Tefa.Domain.Entities;

namespace Tefa.Domain.CognitiveLoadJail.Entities
{
    public class GroupEP
    {
        public required Event Event { get; set; }
        public required int GroupId { get; set; }
        public required Group Group { get; set; }
        public ICollection<GroupEPNote> Notes { get; set; } = [];
    }
}
