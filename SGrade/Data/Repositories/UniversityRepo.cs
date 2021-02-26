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

    public class MajorRepo : GradableRepo<Major>, IMajorRepo
    {
        public MajorRepo(SGradeContext sgcontext) : base(sgcontext)
        {
        }
    }

    public class TeacherRepo : GradableRepo<Teacher>, ITeacherRepo
    {
        public TeacherRepo(SGradeContext sgcontext) : base(sgcontext)
        {
        }
    }

    public class SubjectRepo : GradableRepo<Subject>, ISubjectRepo
    {
        public SubjectRepo(SGradeContext sgcontext) : base(sgcontext)
        {
        }
    }

    public class ReviewRepo : GradableRepo<Review>, IReviewRepo
    {
        public ReviewRepo(SGradeContext sgcontext) : base(sgcontext)
        {
        }
    }
}
