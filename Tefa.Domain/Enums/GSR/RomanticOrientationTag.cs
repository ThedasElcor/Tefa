namespace Tefa.Domain.Enums.GSR
{
    public enum RomanticOrientationTag
    {
        Undefined = 0,
        Unknown = 1,
        Variable = 2,

        Aromantic = 3,
        Demiromantic = 4, // Experiences romantic attraction that grows with emotional closeness
        Alloromantic = 5,      // Experiences romantic attraction
        Frayromantic = 9, // Experiences romantic attraction that fades with emotional closeness
        Quoiromantic = 10, // Experiences attraction but can't distinguish romantic from platonic

        Homoromantic = 6,
        Heteroromantic = 7,
        Multiromantic = 8
    }
}
