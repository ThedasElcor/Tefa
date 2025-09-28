namespace Tefa.Domain.Enums
{
    public enum FunctionalLimitationSource
    {
        Undefined = 0,
        Congenital = 1,       // Present from birth, including birth defects or conditions like cerebral palsy
        Acquired = 2,         // Developed later in life
        Genetic = 3,          // Hereditary or chromosomal
        IllnessRelated = 4,   // Caused by disease or infection
        InjuryRelated = 5,    // Caused by trauma or accident
        Neurological = 6,     // Brain/nervous system origin
        Psychological = 7,    // Mental/emotional origin
        Environmental = 8,    // Caused by external conditions
        SpeciesSpecific = 9,  // Unique to a species
        Fictional = 10        // Lore-based or invented
    }
}
