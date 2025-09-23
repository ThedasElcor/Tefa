
namespace Tefa.Domain.Enums
{
    public enum OrientationSysTag
    {
        Undefined = 0,
        Unknown = 1,
        Variable = 2,        // e.g. Player character

        //Sexuality
        Asexual = 3,        // No sexual attraction, or unconventional sexual attraction
        Demisexual = 4,   // The spectrum between asexual and allosexual
        Multisexual = 5,    // Attracted to multiple genders (e.g., bi, pan)
        Homosexual = 6,     // Attracted to the same gender
        Heterosexual = 7,   // Attracted to other genders only

        //Romantic
        Aromantic = 8,      // No romantic attraction, or unconventional romantic attraction
        Demiromantic = 9, // The spectrum between aromantic and alloromantic
        Multiromantic = 10, // Romantically attracted to multiple genders
        Homoromantic = 11,  // Romantically attracted to the same gender
        Heteroromantic = 12, // Romantically attracted to other genders only

        //Relationship Structure Preferences
        Monogamous = 13,
        Polyflexible = 14,
        Polyamorous = 15,
    }
}
