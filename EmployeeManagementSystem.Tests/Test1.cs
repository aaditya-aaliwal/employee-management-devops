using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void Employee_Properties_Should_Be_Assigned_Correctly()
        {
            Employee employee = new Employee
            {
                Id = 1,
                Name = "Aaditya",
                Email = "aaditya@test.com",
                Department = "IT",
                Salary = 50000
            };

            Assert.AreEqual(1, employee.Id);
            Assert.AreEqual("Aaditya", employee.Name);
            Assert.AreEqual("aaditya@test.com", employee.Email);
            Assert.AreEqual("IT", employee.Department);
            Assert.AreEqual(50000, employee.Salary);
        }

        [TestMethod]
        public void Employee_Name_Should_Not_Be_Null()
        {
            Employee employee = new Employee
            {
                Name = "Aaditya"
            };

            Assert.IsNotNull(employee.Name);
        }

        [TestMethod]
        public void Employee_Email_Should_Not_Be_Null()
        {
            Employee employee = new Employee
            {
                Email = "aaditya@test.com"
            };

            Assert.IsNotNull(employee.Email);
        }

        [TestMethod]
        public void Employee_Salary_Should_Be_Greater_Than_Zero()
        {
            Employee employee = new Employee
            {
                Salary = 50000
            };

            Assert.IsTrue(employee.Salary > 0);
        }
    }
}