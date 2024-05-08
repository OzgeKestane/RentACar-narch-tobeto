using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using MimeKit;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Mailing;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Brands.Queries.GetList;
public class GetListBrandQuery : IRequest<GetListResponse<GetListBrandItemDto>>
{
    public PageRequest PageRequest { get; set; }

    public class GetListBrandQueryHandler : IRequestHandler<GetListBrandQuery, GetListResponse<GetListBrandItemDto>>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;
        private readonly IMailService _mailService;

        public GetListBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper, IMailService mailService)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
            _mailService = mailService;
        }

        public async Task<GetListResponse<GetListBrandItemDto>> Handle(GetListBrandQuery request, CancellationToken cancellationToken)
        {
            Mail mail = new Mail(
                subject: "Deneme maili",
                textBody: "",
                htmlBody: "<p> Merhaba <b> Özge </b> </p>",
                new List<MailboxAddress>() { new("Özge Kestane", "ozge@deneme.com")
                });
            await _mailService.SendEmailAsync(mail);
            IPaginate<Brand> brands = await _brandRepository.GetListAsync(index: request.PageRequest.PageIndex, size: request.PageRequest.PageSize);

            GetListResponse<GetListBrandItemDto> response = _mapper.Map<GetListResponse<GetListBrandItemDto>>(brands);

            return response;
        }
    }
}
