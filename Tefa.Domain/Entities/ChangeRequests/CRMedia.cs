using Tefa.Domain.Entities;

namespace Tefa.Domain.Entities.ChangeRequests
{
    public class CRMedia : ChangeRequest
    {
        public int? MediaItemId { get; set; }
        public Media? ExistingMedia { get; set; }
    }
}
