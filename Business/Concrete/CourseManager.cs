using Business.Abstract;
using DataAccess.Abstract;
using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseSpecifactioManager :ICourseManager
    {
        private readonly ICourseDal _coursedal;

        public CourseSpecifactioManager(ICourseDal coursedal)
        {
            _coursedal = coursedal;
        }

        public void Add(Course course)
        {
            _coursedal.Add(course);
        }

        public List<Course> GetAll()
        {
            return _coursedal.GetAll();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
