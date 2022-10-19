using EmployeeManagement;

namespace TestProject5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSalaryDetailAbleToUpdate()
        {
            //Arrange
            Salary salary = new Salary();
            SalaryUpdateModel salaryUpdateModel = new SalaryUpdateModel()
            {
                SalaryId = 3,
                Month = "March",
                EmployeeSalary = 14000,
                EmployeeID = 1,
            };

            //Act
            int EmpSalary = salary.UpdateEmployeeSalary(salaryUpdateModel);

            //Assert
            Assert.AreEqual(salaryUpdateModel.EmployeeSalary, EmpSalary);
        }
    }
}