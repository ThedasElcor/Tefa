namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class SpeciesVariantLink
    {
        public int GeneralCharacterId { get; set; }
        public required Species GeneralSpecies { get; set; }
        public int SpecificCharacterId { get; set; }
        public required Species SpecificSpecies { get; set; }
        public string? SysNotes { get; set; }
    }
}
