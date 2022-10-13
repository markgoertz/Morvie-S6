using Morvie_Review.Application.Interfaces;
using Morvie_Review.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morvie_Review.Infrastructure.Repositories
{
    public class MockCommandReviewRepository : ICommandReviewRepository
    {
        private readonly MockQueryReviewRepository _repository;
        public MockCommandReviewRepository()
        {
            _repository = new MockQueryReviewRepository();
        }
        public void CreateReview(ReviewDTO review) { 
            _repository.reviewDTOs.Add(review);
        }
    }
}
