namespace Tefa.Domain.Enums.GSR
{
    public enum SexAnatomyTag
    {
        Undefined = 0,
        Unknown = 1,

        // External anatomy
        ExternalGenitaliaPresent = 2,     // Any external sex anatomy
        ExternalGenitaliaAbsent = 3,      // No external sex anatomy
        ExternalGenitaliaAtypical = 4,    // Intersex, ambiguous, or nonstandard
        Cloaca = 5,                        // Single orifice for excretion and reproduction

        // Internal anatomy
        InternalReproductivePresent = 6,  // Uterus, testes, ovaries, etc.
        InternalReproductiveAbsent = 7,   // No internal reproductive anatomy
        InternalReproductiveAtypical = 8, // Mixed, ambiguous, or nonstandard

        // Reproductive capacity
        CapableOfGestation = 9,           // Can carry offspring
        CapableOfFertilization = 10,      // Can produce gametes
        ReproductiveNeutral = 11,         // No reproductive function

        // Interaction capacity
        CapableOfPenetration = 12,        // Can physically penetrate another body
        CapableOfReception = 13,          // Can be physically penetrated
        CapableOfBoth = 14,               // Can alternate or support both roles
        NonpenetrativeReproduction = 15,  // Reproduction occurs without penetration

        // Species-specific or fictional
        NonhumanAnatomy = 16,             // Alien or creature-specific structures
        MultiplexAnatomy = 17,            // Multiple sets or fluid structures
        LoreBoundAnatomy = 18             // Tied to myth, magic, or narrative
    }
}
