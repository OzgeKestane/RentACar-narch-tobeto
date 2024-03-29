using Application.Features.IndividualCustomers.Constants;
using Application.Features.IndividualCustomers.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Logging;

namespace Application.Features.IndividualCustomers.Commands.Create;

public class CreateIndividualCustomerCommand : IRequest<CreatedIndividualCustomerResponse>, ISecuredRequest, ILoggableRequest
{
    public string NationalIdentity { get; set; }
    public Guid CustomerId { get; set; }

    public string[] Roles => new string[] { IndividualCustomersOperationClaims.Create, IndividualCustomersOperationClaims.Write };

    public class CreateIndividualCustomerCommandHandler : IRequestHandler<CreateIndividualCustomerCommand, CreatedIndividualCustomerResponse>
    {
        private readonly IMapper _mapper;
        private readonly IIndividualCustomerRepository _individualCustomerRepository;
        private readonly IndividualCustomerBusinessRules _individualCustomerBusinessRules;

        public CreateIndividualCustomerCommandHandler(IMapper mapper, IIndividualCustomerRepository individualCustomerRepository,
                                         IndividualCustomerBusinessRules individualCustomerBusinessRules)
        {
            _mapper = mapper;
            _individualCustomerRepository = individualCustomerRepository;
            _individualCustomerBusinessRules = individualCustomerBusinessRules;
        }

        public async Task<CreatedIndividualCustomerResponse> Handle(CreateIndividualCustomerCommand request, CancellationToken cancellationToken)
        {
            IndividualCustomer individualCustomer = _mapper.Map<IndividualCustomer>(request);

            await _individualCustomerRepository.AddAsync(individualCustomer);

            CreatedIndividualCustomerResponse response = _mapper.Map<CreatedIndividualCustomerResponse>(individualCustomer);
            return response;
        }
    }
}