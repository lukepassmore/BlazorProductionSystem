namespace ProductionSystem.OrderService
{
    // DTO class for orders
    public class OrderDTO
    {
        // Unique identifier for the order
        public Guid Id { get; set; }

        // Customer reference name - this could be a CustomerId when built out
        public string CustomerName { get; set; }

        // Product reference name - this also could be a productID when built out
        public string Product { get; set; }

        // Order status overview e.g. planning, production, quality, despatch
        public string Status { get; set; }

        // Operation Id that the order is at
        public int OperationId { get; set; }
    }
}
