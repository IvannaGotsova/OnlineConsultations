using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineConsultations.Data;
using OnlineConsultations.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Tests.Mocks
{
    public static class DatabaseMock
    {
        public static OnlineConsultationsDbContext Instance
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<OnlineConsultationsDbContext>()
                    .UseInMemoryDatabase("OnlineConsultationsInnMemoryDb"
                    + DateTime.Now.Ticks.ToString())
                    .Options;

                return new OnlineConsultationsDbContext(dbContextOptions, false);
            }
        }
    }
}
