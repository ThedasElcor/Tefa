using Tefa.Domain.Entities.Shared;

namespace Tefa.Domain.Entities.MetadataCore.Media
{
    public class MediaName : LocalizedName
    {
        public required int MediaId { get; set; }
        public required MediaItem Media {  get; set; }
    }
}
