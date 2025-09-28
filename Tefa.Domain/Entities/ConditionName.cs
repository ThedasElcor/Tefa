using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities
{
    public class ConditionName : LocalizedName
    {
        public required int CharacterId { get; set; }
        public required Character Character { get; set; }
    }
}
