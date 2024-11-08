namespace ProductionSystem.ManufacturingService
{
    // DTO class for process stage
    public class StageDTO
    {
        // Unique identifier for the stage
        public int Id { get; set; }

        // Stage name - displayed against order
        public string Name { get; set; }
    }
}