using SGrade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGrade.Data.Repositories
{
    public interface IUniversityRepo : IGradableRepo<University>
    {
    }

    public interface IMajorRepo : IGradableRepo<Major>
    {

    }
    public interface ITeacherRepo : IGradableRepo<Teacher>
    {

    }
    public interface ISubjectRepo : IGradableRepo<Subject>
    {

    }
    public interface IReviewRepo : IGradableRepo<Review>
    {

    }
}
