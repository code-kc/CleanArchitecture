using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TicketManagement.Application.Features.Orders.GetOrdersForMonth;
using TicketManagement.Domain;

namespace TicketManagement.Application.Contracts.Persistence;

public interface IOrderRepository : IAsyncRepository<Order>
{
  Task<List<OrdersForMonthDto>> GetPagedOrdersForMonth(DateTime date, int page, int size);
  Task<int> GetTotalCountOfOrdersForMonth(DateTime date);
}
