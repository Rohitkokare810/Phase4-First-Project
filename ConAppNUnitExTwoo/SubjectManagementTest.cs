using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppNUnitExTwoo
{
    [TestFixture]
    public class SubjectManagementTest
    {
        SubjectManagement management;
        List<Subject> list;
        [SetUp]
        public void SetUp()
        {
            management = new SubjectManagement();
            list = new List<Subject>();
        }
        [Test]
        public void NotNullTest()
        {
            list = management.AllSubjects();
            foreach (Subject tea in list)
            {
                Assert.IsNotNull(tea.SSId);
                Assert.IsNotNull(tea.SSName);

            }
        }
    }
}
