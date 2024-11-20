using Microsoft.EntityFrameworkCore;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Answer;
using OnlineConsultations.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly IRepository data;

        public AnswerService(IRepository data)
        {
            this.data = data;
        }

        public async Task Add(AddAnswerModelView addAnswerModel)
        {
            var answerToBeAdded = new Answer()
            {
                AnswerDescription = addAnswerModel.AnswerDescription,
                AnswerDate = addAnswerModel.AnswerDate,
                QuestionId = addAnswerModel.QuestionId,
                ProvideUserId = addAnswerModel.ProvideUserId
            };

            await this.data.AddAsync(answerToBeAdded);
            await this.data.SaveChangesAsync();
        }

        public async Task Delete(int answerId)
        {
            await this.data.DeleteAsync<Answer>(answerId);
            await this.data.SaveChangesAsync();
        }

        public async Task<DeleteAnswerModelView> DeleteAnswerForm(int answerId)
        {
            var answerToBeDeleted = await
                GetAnswerById(answerId);

            var deleteAnswerModel = new DeleteAnswerModelView()
            {
                AnswerId = answerToBeDeleted.AnswerId,
                AnswerDescription = answerToBeDeleted.AnswerDescription,
                AnswerDate = answerToBeDeleted.AnswerDate, 
                QuestionId = answerToBeDeleted.QuestionId,
                ProvideUserId = answerToBeDeleted.ProvideUserId
            };

            return deleteAnswerModel;
        }

        public async Task Edit(int answerId, EditAnswerModelView editAnswerModel)
        {
            var answerToBeEdited = await
                GetAnswerById(answerId);

            answerToBeEdited.AnswerDescription = editAnswerModel.AnswerDescription;
            answerToBeEdited.AnswerDate = editAnswerModel.AnswerDate;
            answerToBeEdited.QuestionId = editAnswerModel.QuestionId;
            answerToBeEdited.ProvideUserId = editAnswerModel.ProvideUserId;

            this.data.Update<Answer>(answerToBeEdited);
            await this.data.SaveChangesAsync();
        }

        public async Task<EditAnswerModelView> EditCreateForm(int answerId)
        {
            var answerToBeEdited = await
                GetAnswerById(answerId);

            var editAnswerModel = new EditAnswerModelView()
            {
                AnswerDescription = answerToBeEdited.AnswerDescription,
                AnswerDate = answerToBeEdited.AnswerDate,
                QuestionId = answerToBeEdited.QuestionId,
                ProvideUserId = answerToBeEdited.ProvideUserId,
            };

            return editAnswerModel;
        }

        public async Task<IEnumerable<AllAnswersModelView>> GetAllAnswers()
        {
            var answers = await data
               .AllReadonly<Answer>()
               .ToListAsync();

            return answers
                .Select(a => new AllAnswersModelView()
                {
                    AnswerId = a.AnswerId,
                    AnswerDescription = a.AnswerDescription,
                    AnswerDate = a.AnswerDate,
                    QuestionId = a.QuestionId,
                    ProvideUserId = a.ProvideUserId,
                })
                .ToList();
        }

        public async Task<Answer> GetAnswerById(int answerId)
        {
            var answer = await
              this.data
              .AllReadonly<Answer>()
              .Where(a => a.AnswerId == answerId)
              .FirstOrDefaultAsync();

            if (answer == null)
            {
                throw new ArgumentNullException(null, nameof(answer));
            }

            return answer;
        }

        public async Task<DetailsAnswerModelView> GetAnswerDetailsById(int answerId)
        {
            var answer = await
               this.data
               .AllReadonly<Answer>()
               .Include(a => a.Question)
               .Include(a => a.ProvideUser)
               .Where(a => a.AnswerId == answerId)
               .Select(a => new DetailsAnswerModelView()
               {
                   AnswerId = a.AnswerId,
                   AnswerDescription = a.AnswerDescription,
                   AnswerDate = a.AnswerDate,
                   QuestionId = a.QuestionId,
                   ProvideUserId = a.ProvideUserId,
               }).FirstOrDefaultAsync();

            if (answer == null)
            {
                throw new ArgumentNullException(null, nameof(answer));
            }

            return answer;
        }

        public async Task<IEnumerable<Answer>> GetAnswersForSelect()
        {
            return await
               this.data
               .AllReadonly<Answer>()
               .ToListAsync();
        }
    }
}
