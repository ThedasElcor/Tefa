using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.FandomCore.LocationsAssociated
{
    public class GroupLANote : LocalizedNote
    {
        public required int GroupLAId { get; set; }
        public required GroupLA GroupLA { get; set; }
    }
}
