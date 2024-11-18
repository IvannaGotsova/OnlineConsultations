using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Contracts
{
    public interface IReviewService
    {
        Task<IEnumerable<AllReviewsModelView>> GetAllReviews();

        Task Add(AddReviewModelView addReviewModel);

        Task<IEnumerable<Review>> GetReviewsForSelect();

        Task<DetailsReviewModelView> GetReviewDetailsById(int reviewId);

        Task<EditReviewModelView> EditCreateForm(int reviewId);

        Task Edit(int reviewId, EditReviewModelView editReviewModel);

        Task<Review> GetReviewById(int reviewId);

        Task<DeleteReviewModelView> DeleteReviewForm(int reviewId);

        Task Delete(int reviewId);
    }
}
