using System;
using System.Threading.Tasks;
using TicketManagement.Domain;

namespace TicketManagement.Application.Contracts.Persistence;

public interface IEventRepository : IAsyncRepository<Event>
{
    Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate);
}
