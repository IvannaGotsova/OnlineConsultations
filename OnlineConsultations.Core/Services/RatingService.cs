using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Rating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class RatingService : IRatingService
    {
        public Task Add(AddRatingModelView addRatingModel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int ratingId)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteRatingModelView> DeleteRatingForm(int ratingId)
        {
            throw new NotImplementedException();
        }

        public Task Edit(int ratingId, EditRatingModelView editRatingModel)
        {
            throw new NotImplementedException();
        }

        public Task<EditRatingModelView> EditCreateForm(int ratingId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllRatingsModelView>> GetAllRatings()
        {
            throw new NotImplementedException();
        }

        public Task<Rating> GetRatingById(int ratingId)
        {
            throw new NotImplementedException();
        }

        public Task<DetailsRatingModelView> GetRatingDetailsById(int ratingId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Rating>> GetRatingsForSelect()
        {
            throw new NotImplementedException();
        }
    }
}
