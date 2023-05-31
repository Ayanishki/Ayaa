using DAO;
using DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace Testing
{
    [TestClass]
    public class DAO_LoaiSachTests
    {
        private DAO_LoaiSach dao;

        [TestInitialize]
        public void Setup()
        {
            // Khởi tạo đối tượng DAO_LoaiSach trước mỗi unit test
            dao = new DAO_LoaiSach();
        }

        [TestMethod]
        public void GetLoaiSach_ReturnsDataTable()
        {
            // Arrange

            // Act
            DataTable result = dao.GetLoaiSach();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
        }

        [TestMethod]
        public void GetLoaiSach_WithQuery_ReturnsFilteredDataTable()
        {
            // Arrange
            string query = "SELECT * FROM LoaiSach"; // Thay đổi query theo yêu cầu

            // Act
            DataTable result = dao.GetLoaiSach(query);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Rows.Count > 0);
            // Kiểm tra các điều kiện khác nếu cần thiết
        }

        [TestMethod]
        public void themLoaiSach_ReturnsTrue()
        {
            // Arrange
            DTO_LoaiSach loaiSach = new DTO_LoaiSach
            {
                MaLoai = 1,
                TenLoai = "Loại sách mới",
                Mota = "Mô tả"
            };

            // Act
            bool result = dao.themLoaiSach(loaiSach);

            // Assert
            Assert.IsTrue(result);
            // Kiểm tra các điều kiện khác nếu cần thiết
        }

        [TestMethod]
        public void XoaLoaiSach_ReturnsTrue()
        {
            // Arrange
            DTO_LoaiSach loaiSach = new DTO_LoaiSach
            {
                MaLoai = 1
            };

            // Act
            bool result = dao.XoaLoaiSach(loaiSach);

            // Assert
            Assert.IsTrue(result);
            // Kiểm tra các điều kiện khác nếu cần thiết
        }

        [TestMethod]
        public void SuaLoaiSach_ReturnsTrue()
        {
            // Arrange
            DTO_LoaiSach loaiSach = new DTO_LoaiSach
            {
                MaLoai = 1,
                TenLoai = "Loại sách mới",
                Mota = "Mô tả mới"
            };

            // Act
            bool result = dao.SuaLoaiSach(loaiSach);

            // Assert
            Assert.IsTrue(result);
            // Kiểm tra các điều kiện khác nếu cần thiết
        }

        [TestMethod]
        public void TimKiemLoaiSach_ReturnsTrue()
        {
            // Arrange
            string keywords = "Aya";

            // Act
            bool result = dao.TimKiemLoaiSach(keywords);

            // Assert
            Assert.IsTrue(result);
            // Kiểm tra các điều kiện khác nếu cần thiết
        }
    }
}
