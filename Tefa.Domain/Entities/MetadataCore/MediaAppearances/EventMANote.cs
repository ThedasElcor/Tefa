namespace Tefa.Domain.Entities.MetadataCore.MediaAppearances
{
    public class EventMANote
    {
        public required int EventMAId { get; set; }
        public required EventMA EventMA { get; set; }
    }
}
