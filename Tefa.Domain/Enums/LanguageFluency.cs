
namespace Tefa.Domain.Enums
{
    public enum LanguageFluency
    {
        Unspecified = 0,
        Unknown = 1,

        Native = 2,
        Fluent = 3,
        Rusty = 8, //Fluent or native but forgotten
        Functional = 4,
        Basic = 5,
        Limited = 6,
        Passive = 7, //Understand or read but not communicate
    }
}
