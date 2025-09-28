namespace Tefa.Domain.Enums
{
    public enum GenderIdentity
    {
        Undefined = 0,
        Unknown = 1,
        Cis = 2,             // Gender aligns with sex assigned at birth
        Trans = 3,           // Gender differs from sex assigned at birth
        Agender = 4,         // No gender identity
        Nonbinary = 5,       // Outside male/female binary
        Intergender = 6,     // Between or blending binary categories
        Traditional = 7,     // Culturally specific identities (e.g. Two-Spirit)
        Monogendered = 8,    // Species with a single gender
        Multigendered = 9,   // Fluid or simultaneous gender expressions
        Ungendered = 10      // No gender concept (species-level)
    }
}
