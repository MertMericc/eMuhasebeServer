using MediatR;

namespace eMuhasebeServer.Domain.Events;
public sealed class AppUserEvent:INotification
{
        public Guid UserId { get; set; }
        public AppUserEvent(Guid userId)
        {
            UserId = userId;
        }
}

