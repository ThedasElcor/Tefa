
namespace Tefa.Domain.Entities.MetadataCore.Media
{
    public class MediaComponentLinks
    {
        public required int CompositeMediaId { get; set; }
        public required MediaItem CompositeMedia {  get; set; }
        public required int ComponentMediaId { get; set; }
        public required MediaItem ComponentMedia { get; set; }
    }
}
