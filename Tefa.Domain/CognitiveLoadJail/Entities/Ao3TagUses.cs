using Tefa.Domain.CognitiveLoadJail.FutureDevelopment.Community;

namespace Tefa.Domain.CognitiveLoadJail.Entities
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
