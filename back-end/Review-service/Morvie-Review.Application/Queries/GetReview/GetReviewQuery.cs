using MediatR;
using Morvie_Review.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morvie_Review.Application.Queries.GetReview
{
    public class GetReviewQuery:IRequest<ReviewDTO>
    {
        public Guid Id { get; set; }   
        public GetReviewQuery(Guid id)
        {
            Id = id;
        }
    }
}
