using Grpc.Net.Client;
using Infrastructure;
using System.Threading.Tasks;
using UsersQueueApi.Application.Common.Interfaces.Endpoints;

namespace UsersQueueApi.Infrastructure.Endpoints
{
    public class GrpcEndpoint : IGrpcEndpoint
    {
        public async Task<string> GetGuid()
        {

            var channel = GrpcChannel.ForAddress("http://grpcservice:80");
            var client = new GUId.GUIdClient(channel);
            var response = await client.GetGuidAsync(new GuidRequest { });
            return response.Message;
        }


    }
}
