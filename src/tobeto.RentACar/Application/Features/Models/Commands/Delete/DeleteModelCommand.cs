using Application.Features.Models.Constants;
using Application.Features.Models.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using static Application.Features.Models.Constants.ModelsOperationClaims;

namespace Application.Features.Models.Commands.Delete;

public class DeleteModelCommand : IRequest<DeletedModelResponse>, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, ModelsOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetModels"];

    public class DeleteModelCommandHandler : IRequestHandler<DeleteModelCommand, DeletedModelResponse>
    {
        private readonly IMapper _mapper;
        private readonly IModelRepository _modelRepository;
        private readonly ModelBusinessRules _modelBusinessRules;

        public DeleteModelCommandHandler(IMapper mapper, IModelRepository modelRepository,
                                         ModelBusinessRules modelBusinessRules)
        {
            _mapper = mapper;
            _modelRepository = modelRepository;
            _modelBusinessRules = modelBusinessRules;
        }

        public async Task<DeletedModelResponse> Handle(DeleteModelCommand request, CancellationToken cancellationToken)
        {
            Model? model = await _modelRepository.GetAsync(predicate: m => m.Id == request.Id, cancellationToken: cancellationToken);
            await _modelBusinessRules.ModelShouldExistWhenSelected(model);

            await _modelRepository.DeleteAsync(model!);

            DeletedModelResponse response = _mapper.Map<DeletedModelResponse>(model);
            return response;
        }
    }
}