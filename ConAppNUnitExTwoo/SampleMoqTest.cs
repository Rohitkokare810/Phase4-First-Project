using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppNUnitExTwoo
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Mocking1()
        {
            Mock<Teacher> mockTeach = new Mock<Teacher>();
            Teacher teac = mockTeach.Object;
            Assert.That(teac, Is.Not.Null);

        }
        [Test]
        public void Mocking2()
        {
            Mock<Student> mockStud = new Mock<Student>();
            Student stu = mockStud.Object;
            Assert.That(stu, Is.Not.Null);

        }
        [Test]
        public void Mocking3()
        {
            Mock<Subject> mockSubject = new Mock<Subject>();
            Subject sub = mockSubject.Object;
            Assert.That(sub, Is.Not.Null);

        }
    }
}
