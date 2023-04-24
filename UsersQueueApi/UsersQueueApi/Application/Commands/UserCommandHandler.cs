using Grpc.Net.Client;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UsersQueueApi.Application.Common.Interfaces.Endpoints;
using UsersQueueApi.Application.Common.Interfaces.Services;
using UsersQueueApi.Application.DTOs;
namespace UsersQueueApi.Application.Commands
{
    public class UserCommandHandler : IRequestHandler<UserCommand, UserResponse>
    {
        public readonly IGrpcEndpoint _grpcEndpoint;
        private readonly ILogger<UserCommandHandler> _logger;
        private readonly IUserService _userService;
        public UserCommandHandler(IGrpcEndpoint grpcEndpoint, ILogger<UserCommandHandler> logger, IUserService userService)
        {
            _grpcEndpoint = grpcEndpoint;
            _logger = logger;
            _userService = userService;
        }

        public async  Task<UserResponse> Handle(UserCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation(_userService.GetIp());
            request.users.Enqueue(1);
            var id = await _grpcEndpoint.GetGuid();
            return new UserResponse { fecha = DateTime.Now.ToString("yyyy/MM/dd"), posicion = request.users.Count-1, Uid = id };
        }
    }
}
