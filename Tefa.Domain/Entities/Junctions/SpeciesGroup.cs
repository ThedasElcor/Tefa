namespace Tefa.Domain.Entities.Junctions
{
    public class SpeciesGroup
    {
        public required int GroupId { get; set; }
        public required Group Group { get; set; }
        public required int SpeciesId { get; set; }
        public required Species Species {  get; set; }
        public ICollection<SpeciesGroupNote> Notes { get; set; } = [];
    }
}
