namespace Order.Service.ApiModels;

public record class CreateOrderRequest(List<OrderProductDto> OrderProducts);
