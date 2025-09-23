
using Tefa.Domain.Entities.Groups;
using Tefa.Domain.Entities.Locations;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Junctions
{
    public class GroupLocation
    {
        public required int Id { get; set; }
        public required int GroupId { get; set; }
        public required Group Group { get; set; }
        public required int LocationId { get; set; }
        public required Location Location { get; set; }
        public ICollection<AffiliationType> AffiliationTypes { get; set; } = [];
        public ICollection<Nuance> NuanceNotes { get; set; } = [];
    }
}
