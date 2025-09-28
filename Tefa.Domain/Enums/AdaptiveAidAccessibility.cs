namespace Tefa.Domain.Enums
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public enum AdaptiveAidAccessibility
    {
        Undefined = 0,
        Common = 1,         // Widely available, affordable
        Restricted = 2,     // Requires permission, status, or affiliation
        Rare = 3,           // Expensive, elite, or hard to find
        Experimental = 4,   // Prototype, unstable, or risky
        SpeciesSpecific = 5, // Only usable by certain beings
        GroupSpecific = 6, //Only usable by certain groups of people
        Unique = 7       // Tied to a specific event, prophecy, or artifact
    }
}
