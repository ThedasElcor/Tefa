using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.ConlangAssociations
{
    public class GroupCAInstance : Instance
    {
        public required int GroupCAId { get; set; }
        public required GroupCA GroupCA { get; set; }
    }
}
