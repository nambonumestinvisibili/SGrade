using SGrade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SGrade.Data.Repositories
{
    public class UniversityRepo : GradableRepo<University>, IUniversityRepo
    {
        public UniversityRepo(SGradeContext sgcontext) : base(sgcontext)
        {

        }

        public async Task<University> GetPresentingUniversity(int id)
        {
            IQueryable<University> query = _context.Universities
                .Include(x => x.Reviews)
                .Include(x => x.Majors);

            return await query.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }

    public class MajorRepo : GradableRepo<Major>, IMajorRepo
    {
        public MajorRepo(SGradeContext sgcontext) : base(sgcontext)
        {
        }

        public async Task<Major> GetPresentingMajor(int id)
        {
            IQueryable<Major> query = _context.Majors
                .Include(x => x.Reviews)
                .Include(x => x.Subjects.Take(5))
                .Include(x => x.Teachers.Take(5))
                .Include(x => x.Subjects)
                .Include(x => x.University);

            return await query.Where(x => x.Id == id).FirstOrDefaultAsync();
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
