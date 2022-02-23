using VerseChallenge.Application.Common.Interfaces;

namespace VerseChallenge.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
