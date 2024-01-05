using CleanArc.Application.ViewModels;

namespace CleanArc.Application.Services;

public interface ICourseService
{
    Task<CourseViewModel> GetCoursesAsync();
}
