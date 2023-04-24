using UsersQueueApi.Application.Common.Interfaces;
using System;

namespace UsersQueueApi.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.UtcNow;
    }
}
