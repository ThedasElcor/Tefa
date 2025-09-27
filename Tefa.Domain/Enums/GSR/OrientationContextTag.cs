namespace Tefa.Domain.Enums.GSR
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public enum OrientationContextTag
    {
        Undefined = 0,
        Unknown = 1,

        Closeted = 2,           // Not publicly known
        Out = 3,                // Publicly known and affirmed
        Stigmatized = 4,        // Subject to bias or discrimination
        Celebrated = 5,         // Affirmed or honored culturally
        CulturallySpecific = 6, // Tied to tradition or ritual
        LoreBound = 7,          // Tied to myth, prophecy, or species
        FluidContext = 8,       // Changes based on setting or culture
        Forbidden = 9,          // Punishable or taboo in-world
        Institutionalized = 10, // Legally or socially enforced
    }
}
