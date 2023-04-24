using Grpc.Core;
using GrpcService;

namespace GrpcService.Services
{
    public class GUIdService : GUId.GUIdBase
    {
        private readonly ILogger<GUIdService> _logger;
        public GUIdService(ILogger<GUIdService> logger)
        {
            _logger = logger;
        }

        public override Task<GuidReply> GetGuid(GuidRequest request, ServerCallContext context)
        {
            try
            {
                var replay = new GuidReply();
                Guid g = Guid.NewGuid();
                replay.Message = g.ToString();
                return Task.FromResult(replay);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo generar un id");
            }
            
        }
    }
}