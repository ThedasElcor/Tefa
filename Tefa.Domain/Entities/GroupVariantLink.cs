namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class GroupVariantLink
    {
        public int GeneralGroupId { get; set; }
        public required Group GeneralGroup { get; set; }
        public int SpecifcGroupId { get; set; }
        public required Group SpecificGroup { get; set; }
        public string? SysNotes { get; set; }
    }
}
