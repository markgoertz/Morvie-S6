using MediatR;
using Morvie_Review.Application.Interfaces;
using Morvie_Review.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morvie_Review.Application.Commands
{
    public class CreateReviewHandler : IRequestHandler<CreateReviewCommand, bool>
    {
        private readonly ICommandReviewRepository _repository;
        public CreateReviewHandler(ICommandReviewRepository repository)
        {
            _repository = repository;
        }
        public Task<bool> Handle(CreateReviewCommand request, CancellationToken cancellationToken)
        {
            var review = new ReviewDTO()
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description
            };
            _repository.CreateReview(review);
            return Task.FromResult(true);
        }
    }
}
