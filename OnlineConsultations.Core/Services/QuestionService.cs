using Microsoft.EntityFrameworkCore;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Question;
using OnlineConsultations.Data.Models.Question;
using OnlineConsultations.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IRepository data;

        public QuestionService(IRepository data)
        {
            this.data = data;
        }

        public async Task Add(AddQuestionModelView addQuestionModel)
        {
            var questionToBeAdded = new Question()
            {
                QuestionTitle = addQuestionModel.QuestionTitle,
                QuestionDescription = addQuestionModel.QuestionDescription,
                QuestionDate = addQuestionModel.QuestionDate,
                GuestUserId = addQuestionModel.GuestUserId, 
                SearchUserId = addQuestionModel.SearchUserId
            };

            await this.data.AddAsync(questionToBeAdded);
            await this.data.SaveChangesAsync();
        }

        public async Task Delete(int questionId)
        {
            await this.data.DeleteAsync<Question>(questionId);
            await this.data.SaveChangesAsync();
        }

        public async Task<DeleteQuestionModelView> DeleteQuestionForm(int questionId)
        {
            var questionToBeDeleted = await
                GetQuestionById(questionId);

            var deleteQuestionModel = new DeleteQuestionModelView()
            {
                QuestionId = questionToBeDeleted.QuestionId,
                QuestionTitle = questionToBeDeleted.QuestionTitle,
                QuestionDescription = questionToBeDeleted.QuestionDescription,
                QuestionDate = questionToBeDeleted.QuestionDate,
                GuestUserId = questionToBeDeleted.GuestUserId,
                SearchUserId = questionToBeDeleted.SearchUserId
            };

            return deleteQuestionModel;
        }

        public async Task Edit(int questionId, EditQuestionModelView editQuestionModel)
        {
            var questionToBeEdited = await
                GetQuestionById(questionId);

            questionToBeEdited.QuestionDescription = editQuestionModel.QuestionDescription;
            questionToBeEdited.QuestionTitle = editQuestionModel.QuestionTitle;
            questionToBeEdited.QuestionDate = editQuestionModel.QuestionDate;
            questionToBeEdited.SearchUserId = editQuestionModel.SearchUserId;
            questionToBeEdited.GuestUserId = editQuestionModel.GuestUserId;

            this.data.Update<Question>(questionToBeEdited);
            await this.data.SaveChangesAsync();
        }

        public async Task<EditQuestionModelView> EditCreateForm(int questionId)
        {
            var questionToBeEdited = await
                GetQuestionById(questionId);

            var editQuestionModel = new EditQuestionModelView()
            {
                QuestionTitle = questionToBeEdited.QuestionTitle,
                QuestionDescription = questionToBeEdited.QuestionDescription,
                QuestionDate = questionToBeEdited.QuestionDate,
                SearchUserId = questionToBeEdited.SearchUserId,
                GuestUserId = questionToBeEdited.GuestUserId,
            };

            return editQuestionModel;
        }

        public async Task<IEnumerable<AllQuestionsModelView>> GetAllQuestions()
        {
            var questions = await data
               .AllReadonly<Question>()
               .ToListAsync();

            return questions
                .Select(q => new AllQuestionsModelView()
                {
                    QuestionId = q.QuestionId,
                    QuestionTitle = q.QuestionTitle,
                    QuestionDescription = q.QuestionDescription,
                    QuestionDate = q.QuestionDate,
                    SearchUserId = q.SearchUserId,
                    GuestUserId = q.GuestUserId,
                })
                .ToList();
        }

        public async Task<Question> GetQuestionById(int questionId)
        {
            var question = await
              this.data
              .AllReadonly<Question>()
              .Where(q => q.QuestionId == questionId)
              .FirstOrDefaultAsync();

            if (question == null)
            {
                throw new ArgumentNullException(null, nameof(question));
            }

            return question;
        }

        public async Task<DetailsQuestionModelView> GetQuestionDetailsById(int questionId)
        {
            var question = await
               this.data
               .AllReadonly<Question>()
               .Include(q => q.SearchUser)
               .Include(q => q.GuestUser)
               .Where(q => q.QuestionId == questionId)
               .Select(q => new DetailsQuestionModelView()
               {
                   QuestionId = q.QuestionId,
                   QuestionTitle = q.QuestionTitle,
                   QuestionDescription = q.QuestionDescription,
                   QuestionDate = q.QuestionDate,
                   SearchUserId = q.SearchUserId,
                   GuestUserId = q.GuestUserId,
               }).FirstOrDefaultAsync();

            if (question == null)
            {
                throw new ArgumentNullException(null, nameof(question));
            }

            return question;
        }

        public async Task<IEnumerable<Question>> GetQuestionsForSelect()
        {
            return await
               this.data
               .AllReadonly<Question>()
               .ToListAsync();
        }
    }
}
