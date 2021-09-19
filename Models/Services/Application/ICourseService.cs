using System.Collections.Generic;
using MyCourse.Models.ViewModels;

namespace MyCourse.Models.Services.Application
{
    //l'interfaccia contiene solo eventi e metodi 
    public interface ICourseService
    {
        List<CourseViewModel> GetCourses();
        CourseDetailViewModel GetCourse(int id);
    }
}