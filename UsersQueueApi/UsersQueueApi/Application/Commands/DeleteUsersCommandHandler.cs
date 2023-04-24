using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace UsersQueueApi.Application.Commands
{
    public class DeleteUsersCommandHandler : IRequestHandler<DeleteUsersCommand, bool>
    {
        public Task<bool> Handle(DeleteUsersCommand request, CancellationToken cancellationToken)
        {
            request.users.Clear();
            return request.users.Count == 0 ? Task.FromResult(true) : Task.FromResult(false);
        }
    }
}
