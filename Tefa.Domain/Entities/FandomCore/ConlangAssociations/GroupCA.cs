using Tefa.Domain.Entities.FandomCore.Conlangs;
using Tefa.Domain.Entities.FandomCore.Groups;

namespace Tefa.Domain.Entities.FandomCore.ConlangAssociations
{
    public class GroupCA
    {
        public required int GroupId { get; set; }
        public required Group Group { get; set; }
        public required int ConlangId { get; set; }
        public required Conlang Conlang { get; set; }
    }
}
