namespace Tefa.Domain.Entities.MetadataCore.MediaAppearances
{
    public class RelationshipMANote
    {
        public required int RelationshipMAId { get; set; }
        public required RelationshipMA RelationshipMA { get; set; }
    }
}
