namespace Tefa.Domain.Enums.Disability
{
    public enum DisabilityContextTag
    {
        Undefined = 0,
        Invisible = 1,        // Not outwardly apparent
        Visible = 2,          // Outwardly apparent
        Progressive = 3,      // Worsens over time
        Episodic = 4,         // Comes and goes
        Stable = 5,           // Consistent over time
        Temporary = 6,        // Short-term or recoverable
        Intermittent = 7,     // Unpredictable or fluctuating
        Stigmatized = 8,      // Subject to social bias
        CulturallySpecific = 9,// Interpreted differently across cultures
        LoreBound = 10        // Tied to narrative or myth
    }
}
