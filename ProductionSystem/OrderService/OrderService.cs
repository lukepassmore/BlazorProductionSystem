namespace ProductionSystem.OrderService
{
    // Service class responsible for handling operations related to Orders
    public class OrderService
    {
        // A private list to store orders in memory (acting as a temporary in-memory database for demonstration)
        private readonly List<OrderDTO> _orders;

        // Constructor to initialize demo data
        public OrderService()
        {
            // Initialize the _orders list with sample orders
            _orders = new List<OrderDTO>
            {
                new OrderDTO
                {
                    Id = Guid.NewGuid(),
                    CustomerName = "John Doe",
                    Product = "Packaging Machine A",
                    Status = "In Progress",
                    OperationId = 2  // Component Fabrication
                },
                new OrderDTO
                {
                    Id = Guid.NewGuid(),
                    CustomerName = "Jane Smith",
                    Product = "Packaging Machine B",
                    Status = "Pending",
                    OperationId = 0  // Design Phase
                },
                new OrderDTO
                {
                    Id = Guid.NewGuid(),
                    CustomerName = "Acme Corp",
                    Product = "Packaging Machine C",
                    Status = "Completed",
                    OperationId = 8  // Dispatch and Delivery
                }
            };
        }

        // Method to retrieve all orders
        public IEnumerable<OrderDTO> GetOrders()
        {
            // Return the list of orders as an IEnumerable, so it can be iterated over
            return _orders;
        }

        // Method to create a new order and add it to the array
        public void CreateOrder(OrderDTO newOrder)
        { 
            // Unique ID for the order
            newOrder.Id = Guid.NewGuid();

            // Give the order an initial status
            newOrder.Status = "Planning";

            // Give the order an initial operation Id
            newOrder.OperationId = 0;

            // Add the new order to the array
            _orders.Add(newOrder);
        }

        // Get an order by its uuid
        public OrderDTO? GetOrderById(Guid id) {
            // Find the order id from the list with the matching I
            return _orders.FirstOrDefault(o => o.Id == id);
        }

        // Preogress order operation
        public bool updateOrderOperation(Guid id, int newOperationId) {
            // Find the order by Id
            var order = _orders.FirstOrDefault(o => o.Id == id);

            if (order != null)
            {
                // Update operation stage
                order.OperationId = newOperationId;
                return true;
            }
            return false;
        }
    }
}
