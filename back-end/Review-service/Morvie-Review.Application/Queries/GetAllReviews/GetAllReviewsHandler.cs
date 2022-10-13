using MediatR;
using Morvie_Review.Application.Interfaces;
using Morvie_Review.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morvie_Review.Application.Queries.GetAllReviews
{
    public class GetAllReviewsHandler : IRequestHandler<GetAllReviewsQuery, IEnumerable<ReviewDTO>>
    {
        private readonly IQueryReviewRepository _repository;
        public GetAllReviewsHandler(IQueryReviewRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<ReviewDTO>> Handle(GetAllReviewsQuery request, CancellationToken cancellationToken)
        {
            var reviews = await _repository.GetAll();
            return reviews;
        }
    }
}
