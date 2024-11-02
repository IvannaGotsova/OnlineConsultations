using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Data.DataConstants
{
    internal class DataConstants
    {
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
    }
}
