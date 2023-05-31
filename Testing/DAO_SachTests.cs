using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAO;
using DTO;
using System;
using System.Data;
namespace Testing
{

    [TestClass]
    public class DAO_SachTests
    {
        private DAO_Sach dao;

        [TestInitialize]
        public void Setup()
        {
            // Khởi tạo DAO_Sach trước khi chạy mỗi test case
            dao = new DAO_Sach();
        }

        [TestMethod]
        public void Test_GetSach()
        {
            // Arrange

            // Act
            DataTable result = dao.GetSach();

            // Assert
            Assert.IsNotNull(result); // Kiểm tra kết quả trả về khác null
            Assert.IsTrue(result.Rows.Count > 0); // Kiểm tra số hàng trong kết quả lớn hơn 0
        }

        [TestMethod]
        public void Test_GetSach_WithQuery()
        {
            // Arrange
            string query = "SELECT * FROM Sach";

            // Act

            DataTable result = dao.GetSach(query);
            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0); // Kiểm tra số hàng trong kết lớn hơn 0

        }

        [TestMethod]
        public void Test_themSach()
        {
            // Arrange
            DTO_Sach sach = new DTO_Sach
            {
                MaLoai = 2,
                TenSach = "Overlord",
                Gia = 100,
                SoLuong = 10
            };

            // Act
            bool result = dao.themSach(sach);

            // Assert
            Assert.IsTrue(result);
            // Kiểm tra các điều kiện khác nếu cần thiết
        }

        [TestMethod]
        public void Test_XoaSach()
        {
            // Arrange
            DTO_Sach sach = new DTO_Sach()
            {
                MaSach = 1
            };

            // Act
            var result = dao.XoaSach(sach);

            // Assert
            Assert.IsTrue(result); // Kiểm tra kết quả trả về là true
                                   // Kiểm tra dữ liệu đã được xóa khỏi cơ sở dữ liệu

            // Lấy dữ liệu sách từ cơ sở dữ liệu
            var query = "SELECT * FROM Sach WHERE MaSach = 1";
            var deletedData = dao.GetSach(query);
            Assert.IsNotNull(deletedData);
            Assert.AreEqual(0, deletedData.Rows.Count); // Kiểm tra số hàng trong kết quả bằng 0

        }

        [TestMethod]
        public void Test_SuaSach()
        {
            // Arrange
            DTO_Sach sach = new DTO_Sach
            {
                MaSach = 1,
                TenSach = "Tên Sách mới",
                Gia = 100,
                SoLuong = 10
            };

            // Act
            bool result = dao.SuaSach(sach);

            // Assert
            Assert.IsTrue(result);
            // Kiểm tra các logic khác trong phương thức SuaSach
        }

        [TestMethod]
        public void Test_TimSach()
        {
            // Arrange
            string keywords = "keyword"; // Thay đổi keywords theo yêu cầu

            // Act
            bool result = dao.TimSach(keywords);

            // Assert
            Assert.IsTrue(result);
            // Kiểm tra các logic khác trong phương thức TimSach
        }
    }

}
