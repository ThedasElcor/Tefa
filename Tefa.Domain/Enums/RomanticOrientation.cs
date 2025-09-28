namespace Tefa.Domain.Enums
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public enum RomanticOrientation
    {
        Undefined = 0,
        Unknown = 1,
        Variable = 2,

        Aromantic = 3,
        Demiromantic = 4, // Experiences romantic attraction that grows with emotional closeness
        Alloromantic = 5,      // Experiences romantic attraction
        Frayromantic = 9, // Experiences romantic attraction that fades with emotional closeness
        Quoiromantic = 10, // Experiences attraction but can't distinguish romantic from platonic

        Homoromantic = 6,
        Heteroromantic = 7,
        Multiromantic = 8
    }
}
