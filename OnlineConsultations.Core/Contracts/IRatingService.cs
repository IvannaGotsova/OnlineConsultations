using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Rating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Contracts
{
    public interface IRatingService
    {
        Task<IEnumerable<AllRatingsModelView>> GetAllRatings();

        Task Add(AddRatingModelView addRatingModel);

        Task<IEnumerable<Rating>> GetRatingsForSelect();

        Task<DetailsRatingModelView> GetRatingDetailsById(int ratingId);

        Task<EditRatingModelView> EditCreateForm(int ratingId);

        Task Edit(int ratingId, EditRatingModelView editRatingModel);

        Task<Rating> GetRatingById(int ratingId);

        Task<DeleteRatingModelView> DeleteRatingForm(int ratingId);

        Task Delete(int ratingId);
    }
}
