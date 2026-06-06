using AutoMapper;
using HouseRentingSystem.Services.Infrastructure;
using Microsoft.Extensions.Logging.Abstractions;

namespace HouseRentingSystem.Tests.Mocks
{
    public static class MapperMock
    {
        public static IMapper Instance
        {
            get
            {
                var mapperConfiguration = new MapperConfiguration(config =>
                {
                    config.AddProfile<ServiceMappingProfile>();
                }, NullLoggerFactory.Instance);

                return new Mapper(mapperConfiguration);
            }
        }
    }
}
