using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Data.DataConstants
{
    internal class DataConstants
    {
        public class AnswerConstants
        {
            public const int AnswerDescriptionMinLength = 5;
            public const int AnswerDescriptionMaxLength = 200000;

        }

        public class ApplicationUserConstants
        {
            public const int UserMinLengthUsername = 5;
            public const int UserMaxLengthUsername = 20;

            public const int UserMinLengthEmail = 10;
            public const int UserMaxLengthEmail = 60;

            public const int UserMinLengthPassword = 5;
            public const int UserMaxLengthPassword = 20;

            public const int UserMinLengthFirstName = 5;
            public const int UserMaxLengthFirstName = 20;

            public const int UserMinLengthLastName = 5;
            public const int UserMaxLengthLastName = 20;
        }

        public class CommentConstants
        {
            public const int CommentTitleMinLength = 5;
            public const int CommentTitleMaxLength = 50;

            public const int CommentDescriptionMinLength = 5;
            public const int CommentDescriptionMaxLength = 200000;
        }

        public class MessageConstants
        {
            public const int MessageDescriptionMinLength = 5;
            public const int MessageDescriptionMaxLength = 200000;

        }

        public class PostConstants
        {
            public const int PostTitleMinLength = 5;
            public const int PostTitleMaxLength = 20;
                             
            public const int PostDescriptionMinLength = 5;
            public const int PostDescriptionMaxLength = 200000;
        }

        public class QuestionConstants
        {
            public const int QuestionTitleMinLength = 5;
            public const int QuestionTitleMaxLength = 20;

            public const int QuestionDescriptionMinLength = 5;
            public const int QuestionDescriptionMaxLength = 200000;
        }

        public class RatingConstants
        {
            public const int RatingValueMinLength = 1;
            public const int RatingValueMaxLength = 10;
        }

        public class ReviewConstants
        {
            public const int ReviewDescriptionMinLength = 5;
            public const int ReviewDescriptionMaxLength = 200000;

        }
    }
}
