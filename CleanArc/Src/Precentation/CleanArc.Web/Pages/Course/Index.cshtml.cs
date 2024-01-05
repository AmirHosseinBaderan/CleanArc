using CleanArc.Application.Interfaces;
using CleanArc.Application.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CleanArc.Web.Pages.Course;

public class IndexModel(ICourseService courseService) : PageModel
{
    public CourseViewModel CourseViewModel { get; set; } = null!;

    public void OnGet()
    {
        CourseViewModel = courseService.GetCourses();
    }
}
