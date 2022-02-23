using VerseChallenge.Domain.Common;

namespace VerseChallenge.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
