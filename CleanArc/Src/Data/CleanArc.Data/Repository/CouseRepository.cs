using CleanArc.Domain;
using CleanArc.Domain.Interfaces;

namespace CleanArc.Data.Repository;

public class CourseRepository(CleanArcContext context) : ICourseRepository
{
    public Course? Find(Guid id)
        => context.Course.Find(id);

    public IEnumerable<Course> GetCourses()
        => context.Course;
}
