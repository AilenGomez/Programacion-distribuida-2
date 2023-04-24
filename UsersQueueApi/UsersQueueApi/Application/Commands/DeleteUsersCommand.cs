using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersQueueApi.Application.DTOs;

namespace UsersQueueApi.Application.Commands
{
    public class DeleteUsersCommand : IRequest<bool>
    {
        public Queue users { get; set; }
    }
}
