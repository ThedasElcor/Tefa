using Tefa.Domain.Entities.FandomCore.Groups;
using Tefa.Domain.Entities.FandomCore.Locations;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.FandomCore.LocationsAssociated
{
    public class GroupLA
    {
        public required int Id { get; set; }
        public required int GroupId { get; set; }
        public required Group Group { get; set; }
        public required int LocationId { get; set; }
        public required Location Location { get; set; }
        public ICollection<AffiliationType> AffiliationTypes { get; set; } = [];
        public ICollection<GroupLANote> Notes { get; set; } = [];
    }
}
