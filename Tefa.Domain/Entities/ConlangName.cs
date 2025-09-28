using Tefa.Domain.Entities.Abstract;

namespace Tefa.Domain.Entities
{
    public class ConlangName : LocalizedName
    {
        public required int ConlangId { get; set; }
        public required Conlang Conlang { get; set; }
    }
}
