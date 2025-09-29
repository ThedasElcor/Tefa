namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class EventVariantLink
    {
        public int GeneralEventId { get; set; }
        public required Event GeneralEvent { get; set; }
        public int SpecificEventId { get; set; }
        public required Event SpecificEvent { get; set; }
        public string? SysNotes { get; set; }
    }
}
