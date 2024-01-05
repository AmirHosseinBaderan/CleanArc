using CleanArc.Application.ViewModels;
using CleanArc.Domain;

namespace CleanArc.Application.Interfaces;

public interface ICourseService
{
    CourseViewModel GetCourses();

    Course? GetById(Guid id);
}
