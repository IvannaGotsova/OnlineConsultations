using Microsoft.EntityFrameworkCore;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Review;
using OnlineConsultations.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IRepository data;

        public ReviewService(IRepository data)
        {
            this.data = data;
        }

        public async Task Add(AddReviewModelView addReviewModel)
        {
            var reviewToBeAdded = new Review()
            {
                ReviewDescription = addReviewModel.ReviewDescription, 
                ReviewDate = addReviewModel.ReviewDate,
                SearchUserId = addReviewModel.SearchUserId,
                ProvideUserId = addReviewModel.ProvideUserId
            };

            await this.data.AddAsync(reviewToBeAdded);
            await this.data.SaveChangesAsync();
        }

        public async Task Delete(int reviewId)
        {
            await this.data.DeleteAsync<Review>(reviewId);
            await this.data.SaveChangesAsync();
        }

        public async Task<DeleteReviewModelView> DeleteReviewForm(int reviewId)
        {
            var reviewToBeDeleted = await
                GetReviewById(reviewId);

            var deleteReviewModel = new DeleteReviewModelView()
            {
                ReviewId = reviewToBeDeleted.ReviewId,
                ReviewDescription = reviewToBeDeleted.ReviewDescription,
                ReviewDate = reviewToBeDeleted.ReviewDate,
                SearchUserId = reviewToBeDeleted.SearchUserId,
                ProvideUserId = reviewToBeDeleted.ProvideUserId
            };

            return deleteReviewModel;
        }

        public async Task Edit(int reviewId, EditReviewModelView editReviewModel)
        {
            var reviewToBeEdited = await
                GetReviewById(reviewId);

            reviewToBeEdited.ReviewDescription = editReviewModel.ReviewDescription;
            reviewToBeEdited.ReviewDate = editReviewModel.ReviewDate;
            reviewToBeEdited.SearchUserId = editReviewModel.SearchUserId;
            reviewToBeEdited.ProvideUserId = editReviewModel.ProvideUserId;

            this.data.Update<Review>(reviewToBeEdited);
            await this.data.SaveChangesAsync();
        }

        public async Task<EditReviewModelView> EditCreateForm(int reviewId)
        {
            var reviewToBeEdited = await
                GetReviewById(reviewId);

            var editReviewModel = new EditReviewModelView()
            {
                ReviewDescription = reviewToBeEdited.ReviewDescription,
                ReviewDate = reviewToBeEdited.ReviewDate,
                SearchUserId = reviewToBeEdited.SearchUserId,
                ProvideUserId = reviewToBeEdited.ProvideUserId,
            };

            return editReviewModel;
        }

        public async Task<IEnumerable<AllReviewsModelView>> GetAllReviews()
        {
            var reviews = await data
               .AllReadonly<Review>()
               .ToListAsync();

            return reviews
                .Select(r => new AllReviewsModelView()
                {
                    ReviewId = r.ReviewId,
                    ReviewDescription = r.ReviewDescription,
                    ReviewDate = r.ReviewDate,
                    SearchUserId = r.SearchUserId,
                    ProvideUserId = r.ProvideUserId,
                })
                .ToList();
        }

        public async Task<Review> GetReviewById(int reviewId)
        {
            var review = await
              this.data
              .AllReadonly<Review>()
              .Where(r => r.ReviewId == reviewId)
              .FirstOrDefaultAsync();

            if (review == null)
            {
                throw new ArgumentNullException(null, nameof(review));
            }

            return review;
        }

        public async Task<DetailsReviewModelView> GetReviewDetailsById(int reviewId)
        {
            var review = await
               this.data
               .AllReadonly<Review>()
               .Include(r => r.SearchUserId)
               .Include(r => r.ProvideUserId)
               .Where(r => r.ReviewId == reviewId)
               .Select(r => new DetailsReviewModelView()
               {
                   ReviewId = r.ReviewId,
                   ReviewDescription = r.ReviewDescription,
                   ReviewDate = r.ReviewDate,
                   SearchUserId = r.SearchUserId,
                   ProvideUserId = r.ProvideUserId,
               }).FirstOrDefaultAsync();

            if (review == null)
            {
                throw new ArgumentNullException(null, nameof(review));
            }

            return review;
        }

        public async Task<IEnumerable<Review>> GetReviewsForSelect()
        {
            return await
               this.data
               .AllReadonly<Review>()
               .ToListAsync();
        }
    }
}
