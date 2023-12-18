using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DongHoShop.Models
{
    public class HangSanXuat
    {
        public int ID { get; set; }
        [StringLength(255)]
        [Required(ErrorMessage = "Tên loại sản sản xuất không được bỏ trống!")]
        [DisplayName("Tên Nhà Sản Xuất Đồng Hồ")]
        public string TenHangSanXuat { get; set; }
        public ICollection<SanPham>? SanPham { get; set; }
    }
}
