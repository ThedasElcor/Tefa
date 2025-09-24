using Tefa.Domain.Entities.MetadataCore.Media;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRMedia : ChangeRequest
    {
        public int? MediaItemId { get; set; }
        public MediaItem? ExistingMedia { get; set; }
    }
}
