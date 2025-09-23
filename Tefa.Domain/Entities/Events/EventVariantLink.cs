
namespace Tefa.Domain.Entities.Events
{
    public class EventVariantLink
    {
        public int GeneralEventId { get; set; }
        public required Event GeneralEvent { get; set; }
        public int SpecificEventId { get; set; }
        public required Event SpecificEvent { get; set; }
        public string? SysNotes { get; set; }
    }
}
