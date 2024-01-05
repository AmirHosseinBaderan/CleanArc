using CleanArc.Domain;

namespace CleanArc.Application.ViewModels;

public record CourseViewModel
{
    public IEnumerable<Course> Courses { get; set; }
}
