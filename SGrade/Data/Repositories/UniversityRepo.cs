using SGrade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGrade.Data.Repositories
{
    public class UniversityRepo : GradableRepo<University>, IUniversityRepo
    {
        public UniversityRepo(SGradeContext sgcontext) : base(sgcontext)
        {
        }
    }
}
