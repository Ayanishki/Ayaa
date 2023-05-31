using DAO;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
namespace Testing
{


    [TestClass]
    public class DAO_UserTests
    {
        private DAO_User dao;

        [TestInitialize]
        public void Setup()
        {
            // Khởi tạo đối tượng DAO_User trước mỗi unit test
            dao = new DAO_User();
        }

        [TestMethod]
        public void GetUser_WithQuery_ReturnsDataTable()
        {
            // Arrange
            string query = "SELECT * FROM Users "; // Thay đổi query theo yêu cầu

            // Act
            DataTable result = dao.GetUser(query);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
            // Kiểm tra các điều kiện khác nếu cần thiết
        }

        [TestMethod]
        public void Login_WithValidCredentials_ReturnsTrue()
        {
            // Arrange
            string username = "chien295";
            string password = "chien";

            // Act
            bool result = dao.Login(username, password);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Login_WithInvalidCredentials_ReturnsFalse()
        {
            // Arrange
            string username = "";
            string password = "invalid_password";

            // Act
            bool result = dao.Login(username, password);

            // Assert
            Assert.IsFalse(result);
        }
    }

}
