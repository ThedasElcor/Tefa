namespace Tefa.Domain.Entities
{
    public class RelationshipVariantLink
    {
        public int GeneralCharacterId { get; set; }
        public required Relationship GeneralRelationship { get; set; }
        public int SpecificCharacterId { get; set; }
        public required Relationship SpecificRelationship { get; set; }
        public string? SysNotes { get; set; }
    }
}
