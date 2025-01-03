using System;

namespace Order.Service.Infrastructure.Data;

internal interface IOrderStore
{
    void CreateOrder(Models.Order order);
}
