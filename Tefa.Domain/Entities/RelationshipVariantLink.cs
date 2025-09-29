namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class RelationshipVariantLink
    {
        public int GeneralCharacterId { get; set; }
        public required Relationship GeneralRelationship { get; set; }
        public int SpecificCharacterId { get; set; }
        public required Relationship SpecificRelationship { get; set; }
        public string? SysNotes { get; set; }
    }
}
