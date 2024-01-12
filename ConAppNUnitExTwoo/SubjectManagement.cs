using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppNUnitExTwoo
{
    public class SubjectManagement
    {
        static List<Subject> SubjectList = new List<Subject>()
        {
            new Subject(){SSId=10,SSName="Kannada"},
            new Subject(){SSId=20,SSName="English"},
            new Subject(){SSId=30,SSName="Hindi",},
        };

        public List<Subject> AllSubjects()
        {
            return SubjectList;
        }
        public List<Subject> GetSubjectById(int id)
        {
            List<Subject> searchList = new List<Subject>();
            foreach (var tea in SubjectList)
            {
                if (tea.SSId == id)
                {
                    searchList.Add(tea);
                }
            }
            return searchList;
        }
    }
}
