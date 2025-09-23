
namespace Tefa.Domain.Enums
{
    public enum GenderSysTag
    {
        Undefined = 0,          // System default; indicates unfinished entry or parsing error.
        Unknown = 1,           // Identity not known or deliberately unspecified.
        Variable = 2,              // e.g. Player character
        Agender = 3,       // No gender identity.
        Cis = 4,           // Gender aligns with sex assigned at birth.
        Fem = 5,           // Feminine-presenting or identified.
        Intergender = 7,   // Identity between or outside binary categories.
        Masc = 8,          // Masculine-presenting or identified.
        Monogendered = 9,  // Species with a single gender (e.g. Asari).
        Multigendered = 10,// Fluid or simultaneous gender expressions.
        Nonbinary = 11,    // Outside the male/female binary.
        Traditional = 12,  // Culturally specific identities (e.g. Two-Spirit).
        Trans = 13,        // Gender differs from sex assigned at birth.
        Ungendered = 14    // No gender concept (e.g. insectoid species).
    }
}
