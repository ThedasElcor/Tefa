namespace Tefa.Domain.Enums
{
    public enum SexStructure
    {
        Undefined = 0,
        Unknown = 1,
        Other = 2,

        Binary = 3,              // Two distinct sexes (e.g., male/female)
        NonbinarySystem = 4,     // Includes third or multiple sexes beyond binary
        Monosexed = 5,           // Only one sex exists across the species
        Multisexed = 6,          // Multiple simultaneous sexes per individual
        Asexed = 7,              // No biological sex or reproductive differentiation

        Dimorphic = 8,           // Physical or behavioral differences between sexes
        Polymorphic = 9,         // More than two distinct physical or reproductive forms
        Polygenic = 10,          // Sex determined by multiple genes or alleles
        MatingTypeComplex = 11,  // Hundreds or thousands of reproductive types (e.g., fungi)
        Sequential = 12,         // Sex changes over time or life stage (e.g., clownfish)
        Environmental = 13,      // Sex determined by external factors (e.g., temperature)
        Symbiotic = 14           // Sex or reproduction depends on another species or host

    }
}
