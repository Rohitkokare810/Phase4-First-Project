using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppNUnitExTwoo
{
    public class StudentManagement
    {
        static List<Student> studentList = new List<Student>()
        {
            new Student(){SId=10,SName="Rohit Kokare"},
            new Student(){SId=20,SName="Harish"},
            new Student(){SId=30,SName="Nikhil",},
        };

        public List<Student> AllStudents()
        {
            return studentList;
        }
        public List<Student> GetStudentById(int id)
        {
            List<Student> searchList = new List<Student>();
            foreach (var tea in studentList)
            {
                if (tea.SId == id)
                {
                    searchList.Add(tea);
                }
            }
            return searchList;
        }
    }
}
