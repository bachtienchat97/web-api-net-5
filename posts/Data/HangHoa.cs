using posts.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace posts.Data
{
    [Table("HangHoa")]
    public class HangHoa

    {   //Guid: nếu dữ liệu nhiều
        [Key]
        public Guid MaHh { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenHh { get; set; }
        [Range(0, double.MaxValue)]
        public double DonGia { get; set; }
        public string Mota { get; set; }
        public byte GiamGia { get; set; }
        public int? MaLoai { get; set; }

        [ForeignKey("MaLoai")]
        public Loai Loai { get; set; }

        public ICollection<DonHangChiTiet> DonHangChiTiets { get; set; }

        public HangHoa()
        {
            DonHangChiTiets = new List<DonHangChiTiet>();
        }
    }
}
