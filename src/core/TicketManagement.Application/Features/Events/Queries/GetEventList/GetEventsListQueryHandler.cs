using AutoMapper;
using MediatR;
using TicketManagement.Application.Contracts.Persistence;
using TicketManagement.Domain;

namespace TicketManagement.Application.Features.Events.Queries.GetEventList;

public class GetEventsListQueryHandler : IRequestHandler<GetEventsListQuery, List<EventListVm>>
{
    private readonly IMapper mapper;
    private readonly IAsyncRepository<Event> eventRepository;

    public GetEventsListQueryHandler(IMapper mapper, IAsyncRepository<Event> eventRepository)
    {
        this.mapper = mapper;
        this.eventRepository = eventRepository;
    }

    public async Task<List<EventListVm>> Handle(GetEventsListQuery request, CancellationToken cancellationToken)
    {
        IOrderedEnumerable<Event> allEvents = (await eventRepository.ListAllAsync()).OrderBy(x => x.Date);
        return mapper.Map<List<EventListVm>>(allEvents);
    }
}
