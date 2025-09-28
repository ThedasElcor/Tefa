namespace Tefa.Domain.CognitiveLoadJail.Enums.Community
{
    public enum CommunityEventTransactionType
    {
        Undefined = 0, // Default value, generally represents system error
        Freeform = 1, // Just text, needs to manually be handled

        Character = 2,
        Event = 3,
        Group = 4,
        Language = 5,
        Location = 6,
        Relationship = 7,
    }
}
