using Application.Services.ImageService;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Features.Customers.AddPicture;
public class AddPictureCommand : IRequest<AddPictureResponse>
{
    public IFormFile File { get; set; }

    public class AddPictureCommandHandler : IRequestHandler<AddPictureCommand, AddPictureResponse>
    {
        private readonly ImageServiceBase _imageService;

        public AddPictureCommandHandler(ImageServiceBase imageService)
        {
            _imageService = imageService;
        }

        public async Task<AddPictureResponse> Handle(AddPictureCommand request, CancellationToken cancellationToken)
        {
            string url = await _imageService.UploadAsync(request.File);
            return new AddPictureResponse() { Url = url };
        }
    }
}
