using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class ReviewService : IReviewService
    {
        public Task Add(AddReviewModelView addReviewModel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int reviewId)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteReviewModelView> DeleteReviewForm(int reviewId)
        {
            throw new NotImplementedException();
        }

        public Task Edit(int reviewId, EditReviewModelView editReviewModel)
        {
            throw new NotImplementedException();
        }

        public Task<EditReviewModelView> EditCreateForm(int reviewId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllReviewsModelView>> GetAllReviews()
        {
            throw new NotImplementedException();
        }

        public Task<Review> GetReviewById(int reviewId)
        {
            throw new NotImplementedException();
        }

        public Task<DetailsReviewModelView> GetReviewDetailsById(int reviewId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Review>> GetReviewsForSelect()
        {
            throw new NotImplementedException();
        }
    }
}
