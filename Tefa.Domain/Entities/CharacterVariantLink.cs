namespace Tefa.Domain.Entities
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public class CharacterVariantLink
    {
            public int GeneralCharacterId { get; set; }
            public required Character GeneralCharacter { get; set; }
            public int SpecificCharacterId { get; set; }
            public required Character SpecificCharacter { get; set; }
            public string? SysNotes { get; set; }
    }
}
