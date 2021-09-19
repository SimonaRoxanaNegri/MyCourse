using System.Collections.Generic;
using System.Data;
using MyCourse.Models.Services.Infrastructure;
using MyCourse.Models.ViewModels;

// il servizio applicativo ha l'obbiettivo di sapere COSA ESTRARRE dal db
// il servizio infrastrutturale ha l'obbiettivo di sapere COME ESTRARRE dal db

namespace MyCourse.Models.Services.Application
{
    // il servizio applicativo dovrà collegarsi al servizio infrastrutturale per ottenere le informazioni ottenute dal db, quindi creare una dipendenza con il costruttore (dependency injection)

    public class AdoNetCourseService : ICourseService
    {
        private readonly IDatabaseAccessor db;

        public AdoNetCourseService(IDatabaseAccessor db)
        {
            this.db = db;
        }
        public CourseDetailViewModel GetCourse(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<CourseViewModel> GetCourses()
        {
            string query = "SELECT * FROM Courses";
            DataSet dataSet = db.Query(query);
            throw new System.NotImplementedException();
        }
    }
}