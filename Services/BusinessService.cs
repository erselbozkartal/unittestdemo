using Integrations;

namespace Services
{
    public class BusinessService : IBusinessService
    {
        public readonly IRedisRepository redisRepository;

        public BusinessService(IRedisRepository _redisRepository)
        {
            redisRepository = _redisRepository;
        }

        public int Get()
        {
            return redisRepository.Get();
        }
    }
}