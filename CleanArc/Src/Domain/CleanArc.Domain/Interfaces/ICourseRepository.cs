namespace CleanArc.Domain.Interfaces;

public interface ICourseRepository
{
    Task<IEnumerable<Course>> GetCoursesAsync();
}
