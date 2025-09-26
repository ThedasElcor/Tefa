using Tefa.Domain.Entities.FandomCore.Events;
using Tefa.Domain.Entities.MetadataCore.Media;
using Tefa.Domain.Enums;

namespace Tefa.Domain.Entities.MetadataCore.MediaAppearances
{
   public class EventMA
    {
        public required int Id { get; set; }
        public required int EventId { get; set; }
        public required Event Event { get; set; }
        public required int MediaId { get; set; }
        public required MediaItem Media {  get; set; }
        public required EntityAppearanceType AppearanceType { get; set; }
        public ICollection<EventMANote> Notes { get; set; } = [];
    }
}
