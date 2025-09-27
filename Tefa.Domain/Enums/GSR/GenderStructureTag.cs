namespace Tefa.Domain.Enums.GSR
{
    public enum GenderStructureTag
    {
        Undefined = 0,
        Binary = 1,          // Male/female system
        NonbinarySystem = 2, // Includes third or multiple genders
        Monogendered = 3,    // Only one gender exists
        Multigendered = 4,   // Multiple simultaneous genders
        Ungendered = 5,      // No gender concept
        CulturallyDefined = 6, // Gender defined by tradition or ritual
        Variable = 7         // Player-defined or context-dependent
    }
}
