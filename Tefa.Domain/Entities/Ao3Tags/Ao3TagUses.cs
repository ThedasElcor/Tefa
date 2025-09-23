using Tefa.Domain.Entities.Community;
using Tefa.Domain.Entities.Events;

namespace Tefa.Domain.Entities.Ao3Tags
{
    public class Ao3TagUses
    {
        public required int Id { get; set; }
        public required int Ao3TagId { get; set; }
        public required Ao3Tag Ao3Tag { get; set; }
        public ICollection<Tagset> Tagsets { get; set; } = [];
        public ICollection<FanWork> FanWorks { get; set; } = [];
    }
}
