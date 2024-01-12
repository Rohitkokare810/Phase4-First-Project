using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppNUnitExTwoo
{
    public class TeacherManagement
    {
        static List<Teacher> teacherList = new List<Teacher>()
        {
            new Teacher(){TId=1,TName="Rohit",Salary=25000},
            new Teacher(){TId=2,TName="Harish",Salary=20000},
            new Teacher(){TId=3,TName="Nikhil",Salary=35000},
        };

        public List<Teacher> AllTeachers()
        {
            return teacherList;
        }
        public List<Teacher> GetTeacherById(int id)
        {
            List<Teacher> searchList = new List<Teacher>();
            foreach (var tea in teacherList)
            {
                if (tea.TId == id)
                {
                    searchList.Add(tea);
                }
            }
            return searchList;
        }
    }
}
