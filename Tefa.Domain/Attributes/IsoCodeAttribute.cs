namespace Tefa.Domain.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class IsoCodeAttribute(string code) : Attribute
    {
        public string Code { get; } = code;
    }
}
