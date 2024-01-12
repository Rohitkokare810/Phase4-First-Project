using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppNUnitExTwoo
{
    [TestFixture]
    public class StudentManagementTest
    {
        StudentManagement management;
        List<Student> list;
        [SetUp]
        public void SetUp()
        {
            management = new StudentManagement();
            list = new List<Student>();
        }
        [Test]
        public void NotNullTest()
        {
            list = management.AllStudents();
            foreach (Student tea in list)
            {
                Assert.IsNotNull(tea.SId);
                Assert.IsNotNull(tea.SName);
                
            }
        }
    }
}
