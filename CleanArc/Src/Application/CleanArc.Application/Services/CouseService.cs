using CleanArc.Application.Interfaces;
using CleanArc.Application.ViewModels;
using CleanArc.Domain.Interfaces;

namespace CleanArc.Application.Services;

public class CouseService(ICourseRepository courseRepository) : ICourseService
{
    public CourseViewModel GetCourses()
    {
        var courses = courseRepository.GetCourses();
        return new()
        {
            Courses = courses,
        };
    }
}
