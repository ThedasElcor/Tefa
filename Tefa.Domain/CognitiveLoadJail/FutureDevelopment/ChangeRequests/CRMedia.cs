using Tefa.Domain.Entities;

namespace Tefa.Domain.CognitiveLoadJail.FutureDevelopment.ChangeRequests
{
    public class CRMedia : ChangeRequest
    {
        public int? MediaItemId { get; set; }
        public Media? ExistingMedia { get; set; }
    }
}
