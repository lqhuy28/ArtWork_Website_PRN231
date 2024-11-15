using AWS_BusinessObjects.Common.Interfaces;

namespace AWS_BusinessObjects.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
