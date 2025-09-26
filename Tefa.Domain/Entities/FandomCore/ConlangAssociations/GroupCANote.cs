using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.ConlangAssociations
{
    public class GroupCANote : LocalizedNote
    {
        public required int GroupCAId { get; set; }
        public required GroupCA GroupCA { get; set; }
    }
}
