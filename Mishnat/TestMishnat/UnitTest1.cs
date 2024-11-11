using Microsoft.AspNetCore.Mvc;
using Mishnat.Controllers;
using Mishnat.NewFolder;
using Mishnat.Service;

namespace TestMishnat
{
    public class UnitTest1
    {

        //Arrange - ארגון הנתונים הנדרשים להפעלת הפונקציה
        //Act - הפעלת הפונקציה האמיתית
        //Assert - הכרזה על התוצאה הצפויה והרצויה

        [Fact]
        public void GetById_ReturnsOk()
        {
            //Arrange
            var id = 112;

            //Act
            var controller = new UserController();
            var result = controller.GetById(id);
            Assert.IsType<User>(result);
           

            //Assert.True(result is User || result == null);
            // Assert
            //if (result != null)
            //{
            //    Assert.IsType<User>(result);
            //}
            //else
            //{
            //   Assert.Null(result);
            //}

        }


        [Fact]
        public void GetAll_ReturnsCount()
        {
            var controller = new UserController();
            var result = controller.GetUsers();
            Assert.Equal(0,result.Value.Count);
        }
        [Fact]
        public void AddUser_ReturnFalse()
        {
            var user = new User();
            var controller = new UserController();
            var res=controller.AddUser(user);
            Assert.True(!res.Value);
        }
        [Fact]
        public void UpdateUser_ReturnTrue()
        {
            var user = new User();
            var controller = new UserController();
            var resUser = controller.AddUser(user);
            var resUsers= controller.GetUsers();
            Assert.True(resUsers.Value.Count == controller.GetUsers().Value.Count&& !resUser.Value);
            
        }
        [Fact]
        public void DeleteUser_ReturnFalse()
        {
            var id = -1;
            var controller = new UserController();
            var res = controller.Delete(id);
            Assert.True(!res.Value);
        }

    }
}