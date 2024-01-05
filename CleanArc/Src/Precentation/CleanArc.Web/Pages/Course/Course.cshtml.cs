using CleanArc.Application.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CleanArc.Web.Pages.Course;

public class CourseModel(ICourseService courseService) : PageModel
{
    public CleanArc.Domain.Course? Course { get; set; }

    public void OnGet(Guid id)
    {
        Course = courseService.GetById(id);
    }
}
