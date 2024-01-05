using CleanArc.Application.Interfaces;
using CleanArc.Application.ViewModels;
using CleanArc.Domain;
using CleanArc.Domain.Interfaces;

namespace CleanArc.Application.Services;

public class CourseService(ICourseRepository courseRepository) : ICourseService
{
    public Course? GetById(Guid id)
            => courseRepository.Find(id);

    public CourseViewModel GetCourses()
    {
        var courses = courseRepository.GetCourses();
        return new()
        {
            Courses = courses,
        };
    }
}
