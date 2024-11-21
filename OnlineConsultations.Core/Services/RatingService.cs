using Microsoft.EntityFrameworkCore;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Rating;
using OnlineConsultations.Data.Models.Rating;
using OnlineConsultations.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class RatingService : IRatingService
    {
        private readonly IRepository data;

        public RatingService(IRepository data)
        {
            this.data = data;
        }

        public async Task Add(AddRatingModelView addRatingModel)
        {
            var ratingToBeAdded = new Rating()
            {
                RatingValue = addRatingModel.RatingValue,
                SearchUserId = addRatingModel.SearchUserId,
                ProvideUserId = addRatingModel.ProvideUserId
            };

            await this.data.AddAsync(ratingToBeAdded);
            await this.data.SaveChangesAsync();
        }

        public async Task Delete(int ratingId)
        {
            await this.data.DeleteAsync<Rating>(ratingId);
            await this.data.SaveChangesAsync();
        }

        public async Task<DeleteRatingModelView> DeleteRatingForm(int ratingId)
        {
            var ratingToBeDeleted = await
                GetRatingById(ratingId);

            var deleteRatingModel = new DeleteRatingModelView()
            {
                RatingId = ratingToBeDeleted.RatingId,
                RatingValue = ratingToBeDeleted.RatingValue,
                SearchUserId = ratingToBeDeleted.SearchUserId,
                ProvideUserId = ratingToBeDeleted.ProvideUserId
            };

            return deleteRatingModel;
        }

        public async Task Edit(int ratingId, EditRatingModelView editRatingModel)
        {
            var ratingToBeEdited = await
                GetRatingById(ratingId);

            ratingToBeEdited.RatingValue = editRatingModel.RatingValue;
            ratingToBeEdited.SearchUserId = editRatingModel.SearchUserId;
            ratingToBeEdited.ProvideUserId = editRatingModel.ProvideUserId;

            this.data.Update<Rating>(ratingToBeEdited);
            await this.data.SaveChangesAsync();
        }

        public async Task<EditRatingModelView> EditCreateForm(int ratingId)
        {
            var ratingToBeEdited = await
                GetRatingById(ratingId);

            var editRatingModel = new EditRatingModelView()
            {
                RatingValue = ratingToBeEdited.RatingValue,
                SearchUserId = ratingToBeEdited.SearchUserId,
                ProvideUserId = ratingToBeEdited.ProvideUserId,
            };

            return editRatingModel;
        }

        public async Task<IEnumerable<AllRatingsModelView>> GetAllRatings()
        {
            var ratings = await data
               .AllReadonly<Rating>()
               .ToListAsync();

            return ratings
                .Select(r => new AllRatingsModelView()
                {
                    RatingId = r.RatingId,
                    RatingValue = r.RatingValue,
                    SearchUserId = r.SearchUserId,
                    ProvideUserId = r.ProvideUserId,
                })
                .ToList();
        }

        public async Task<Rating> GetRatingById(int ratingId)
        {
            var rating = await
              this.data
              .AllReadonly<Rating>()
              .Where(r => r.RatingId == ratingId)
              .FirstOrDefaultAsync();

            if (rating == null)
            {
                throw new ArgumentNullException(null, nameof(rating));
            }

            return rating;
        }

        public async Task<DetailsRatingModelView> GetRatingDetailsById(int ratingId)
        {
            var rating = await
               this.data
               .AllReadonly<Rating>()
               .Include(r => r.SearchUserId)
               .Include(r => r.ProvideUserId)
               .Where(r => r.RatingId == ratingId)
               .Select(r => new DetailsRatingModelView()
               {
                   RatingId = r.RatingId,
                   RatingValue = r.RatingValue,
                   SearchUserId = r.SearchUserId,
                   ProvideUserId = r.ProvideUserId,
               }).FirstOrDefaultAsync();

            if (rating == null)
            {
                throw new ArgumentNullException(null, nameof(rating));
            }

            return rating;
        }

        public async Task<IEnumerable<Rating>> GetRatingsForSelect()
        {
            return await
               this.data
               .AllReadonly<Rating>()
               .ToListAsync();
        }
    }
}
