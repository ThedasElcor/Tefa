namespace Tefa.Domain.Enums
{
    #region Watermark
    /*  Thedas Elcor's Fandom App (TEFA)
    *   [With bashful pride] Only my engine thinks about Fandom like we do.
    *   https://github.com/ThedasElcor/Tefa */
    #endregion
    public enum SpeciesOrigin
    {
        Undefined = 0,
        Unknown = 1,
        Other = 2,

        Biological = 6,
        Corruption = 11,
        Divine = 13, // E.g. Angels
        Engineered = 3,  // Created by another species or force
        Ethereal = 4, // Like ghosts, 
        Elemental = 14,
        Infernal = 10,
        Infomorphic = 12, //Digital beings caused by corrupted memories, emergent data, not necessarily engineered
        Magical= 7, // Created by a mage, or as a result of magic
        Noetic = 8, // From thought or reason
        Oneiric = 16, // From dreams
        Primordial = 15,
        Psychogenic = 5, // Trauma-born spirits, hallucinated companions, Jungian shadow-beasts.
        SelfInstantiation = 17,
        Undead = 9,
    }
}
