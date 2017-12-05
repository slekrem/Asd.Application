namespace Asd.Application.Services
{
    using Asd.Domain.Core.Bus;
    using AutoMapper;
    using System;

    public abstract class AsdAppService
    {
        private readonly IAsdBus _bus;
        private readonly IMapper _mapper;
        protected IAsdBus Bus { get { return _bus; } }
        protected IMapper Mapper { get { return _mapper; } }
        protected AsdAppService(IAsdBus bus, IMapper mapper)
        {
            _bus = bus ?? throw new ArgumentNullException(nameof(bus));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
    }
}
