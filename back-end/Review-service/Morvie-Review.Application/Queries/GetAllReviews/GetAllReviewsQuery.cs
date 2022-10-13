using MediatR;
using Morvie_Review.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morvie_Review.Application.Queries.GetAllReviews
{
    public class GetAllReviewsQuery:IRequest<IEnumerable<ReviewDTO>>
    {
    }
}
