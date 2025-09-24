using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.Conlangs
{
    public class ConlangName : LocalizedName
    {
        public required int ConlangId { get; set; }
        public required Conlang Conlang { get; set; }
    }
}
