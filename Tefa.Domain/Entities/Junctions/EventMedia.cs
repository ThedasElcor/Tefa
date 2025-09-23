
using Tefa.Domain.Entities.Events;
using Tefa.Domain.Entities.Media;
using Tefa.Domain.Entities.Shared;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.Junctions
{
   public class EventMedia
    {
        public required int Id { get; set; }
        public required int EventId { get; set; }
        public required Event Event { get; set; }
        public required int MediaId { get; set; }
        public required MediaItem Media {  get; set; }
        public required EntityAppearanceType AppearanceType { get; set; }
        public ICollection<Nuance> NuanceNotes { get; set; } = [];
    }
}
