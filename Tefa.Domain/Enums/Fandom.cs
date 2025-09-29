namespace Tefa.Domain.Enums
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public enum Fandom
    {
        Undefined = 0, //Default for errors or unsupported crossovers (temp)
        IRL = 1, // For real-world, commonly shared entities and RPF

        BaldursGate = 8,
        BBCMerlin = 6,
        CriticalRole = 10,
        DragonAge = 4,
        TheElderScrolls = 9,
        MassEffect = 2,
        TheOuterWorlds = 12,
        Overwatch = 3,
        Pokemon = 13,
        Stargate = 15,
        StarTrek = 14,
        StarWars = 11,
        TheWitcher = 7,
    }
}
