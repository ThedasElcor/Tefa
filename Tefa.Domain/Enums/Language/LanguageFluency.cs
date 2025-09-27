namespace Tefa.Domain.Enums.Language
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public enum LanguageFluency
    {
        Unspecified = 0,
        Unknown = 1,

        Native = 2,
        Fluent = 3,
        Conversational = 4,
        Basic = 5,
        Limited = 6,
        Passive = 7, //Understand or read but not communicate
    }
}
