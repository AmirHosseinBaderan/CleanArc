using CleanArc.Domain;
using CleanArc.Domain.Interfaces;

namespace CleanArc.Data.Repository;

public class CouseRepository(CleanArcContext context) : ICourseRepository
{
    public IEnumerable<Course> GetCourses()
        => context.Course;
}
