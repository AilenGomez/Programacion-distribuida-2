using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersQueueApi.Application.Common.Interfaces.Endpoints
{
    public interface IGrpcEndpoint
    {
        Task<string> GetGuid();
    }
}
