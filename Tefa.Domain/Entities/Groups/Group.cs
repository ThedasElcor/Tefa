using Tefa.Domain.Entities.Characters;
using Tefa.Domain.Entities.Events;
using Tefa.Domain.Entities.Locations;

namespace Tefa.Domain.Entities.Groups
{
    public class Group
    {
        public required int Id { get; set; }
        public string? SysName { get; set; } //For administrative convenience, use Names to support localization and variants
        public ICollection<GroupName> Names { get; set; } = [];
        public ICollection<GroupDescription> Descriptions { get; set; } = [];
        public ICollection<Location> AssociatedLocations { get; set; } = [];
        public ICollection<Event> AssociatedEvents { get; set; } = [];
        public ICollection<Character> AssociatedCharacters {  get; set; } = [];

    }
}
