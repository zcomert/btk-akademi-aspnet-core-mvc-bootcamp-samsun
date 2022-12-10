namespace Entities.DataTransferObjects
{
    public record ProductForUpdateDto : ProductManipulationDto
    {
        public int Id { get; set; }
    }
}
