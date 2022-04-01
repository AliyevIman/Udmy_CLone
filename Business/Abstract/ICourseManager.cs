using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseManager
    {
        List<Course> GetAll();
        void Add(Course course);
        void Remove(int id);
        void Update(Course course);


    }
}
