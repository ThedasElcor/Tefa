namespace Tefa.Domain.Enums
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public enum Attraction
    {
        Undefined = 0,
        Unknown = 1,

        // Gendered attraction
        AttractedToMen = 2,
        AttractedToWomen = 3,
        AttractedToNonbinaryPeople = 4,
        AttractedToFemPresenting = 5,
        AttractedToMascPresenting = 6,
        ExclusivelyAttractedToCis = 19, //Couldn't relate but I guess we should give people the option
        ExclusivelyAttrractedToTrans = 20,

        // Species-specific or fandom
        AttractedToAliens = 7,
        AttractedToHumans = 8,
        AttractedToAndroids = 9,
        AttractedToMonsters = 10,
        AttractedToAnthros = 11,
        AttractedToMagicBeings = 12,
        AttractedToLoreBoundEntities = 13,

        // Conceptual or fluid
        AttractedToPersonality = 14,   // Into band geeks, Into Artists, Into Nerds, etc.
        AttractedToEnergy = 15,        // Aura, soul, magical resonance
        AttractedToPresentation = 16,  // Style, vibe, aesthetic
        AttractedToPower = 17,         // Authority, strength, dominance
        AttractedToMystery = 18,       // Obscured, masked, unknowable

        Indiscriminate = 21, // Broad, inclusive attraction to regardless of subject

    }
}
