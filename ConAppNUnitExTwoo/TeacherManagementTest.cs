using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppNUnitExTwoo
{
    [TestFixture]
    public class TeacherManagementTest
    {
        TeacherManagement management;
        List<Teacher> list;
        [SetUp]
        public void SetUp()
        {
            management = new TeacherManagement();
            list = new List<Teacher>();
        }
        [Test]
        public void NotNullTest()
        {
            list = management.AllTeachers();
            foreach (Teacher tea in list)
            {
                Assert.IsNotNull(tea.TId);
                Assert.IsNotNull(tea.TName);
                Assert.IsNotNull(tea.Salary);
            }
        }
    }
}
