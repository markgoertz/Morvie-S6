using MediatR;
using Morvie_Review.Application.Interfaces;
using Morvie_Review.Application.Queries.GetAllReviews;
using Morvie_Review.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morvie_Review.Application.Queries.GetReview
{
   
    public class GetReviewHandler : IRequestHandler<GetReviewQuery, ReviewDTO>
    {
        private readonly IQueryReviewRepository _repository;
        public GetReviewHandler(IQueryReviewRepository repository)
        {
            _repository = repository;
        }
          
        public async Task<ReviewDTO> Handle(GetReviewQuery request, CancellationToken cancellationToken)
        {
            var review = await _repository.GetById(request.Id);
            return review;
        }
    }
    
}
