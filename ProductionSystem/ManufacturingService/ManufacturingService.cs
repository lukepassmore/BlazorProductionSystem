using ProductionSystem.OrderService;

namespace ProductionSystem.ManufacturingService
{
    public class ManufacturingService
    {
        // A private list to store stages in memory (acting as a temporary in-memory database for demonstration)
        private readonly List<StageDTO> _stages;

        // Constructor to initialize demo data
        public ManufacturingService()
        {
            // Initialize the _orders list with sample orders
            _stages = new List<StageDTO>
            {
                new StageDTO
                {
                    Id = 1,
                    Name = "Pending",
                },
                new StageDTO
                {
                    Id = 2,
                    Name = "Design",
                },
                new StageDTO
                {
                    Id = 3,
                    Name = "Material Planning",
                },
                new StageDTO
                {
                    Id = 3,
                    Name = "BoM Fabrication",
                },
                new StageDTO
                {
                    Id = 4,
                    Name = "BoM Assembley",
                },
                new StageDTO
                {
                    Id = 5,
                    Name = "Inspection",
                },

                new StageDTO
                {
                    Id = 6,
                    Name = "PLC Assembley",
                },
                new StageDTO
                {
                    Id = 7,
                    Name = "Final QA",
                },
                new StageDTO
                {
                    Id = 8,
                    Name = "Packing",
                },
                new StageDTO
                {
                    Id = 9,
                    Name = "Despatch",
                },
                new StageDTO
                {
                    Id = 0,
                    Name = "Unknown Stage",
                }
            };
        }

        // Method to retrieve all stages
        public IEnumerable<StageDTO> GetOrders()
        {
            // Return the list of stages as an IEnumerable, so it can be iterated over
            return _stages;
        }

        // Method to create a new process stage
        public void CreateStage(StageDTO newStage)
        {
            int randomId = Random.Shared.Next(1000, 10000);

            // Unique ID for the order
            newStage.Id = randomId;

            // Add the new stage to the array
            _stages.Add(newStage);
        }
    }
}
