using NguyenHoangLongMVC.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NguyenHoangLongMVC.Web.ViewModels
{
    public class CategoryModel
    {
        [Required]
        public short CategoryID { get; set; }

        [StringLength(100)]
        [Required]
        public string CategoryName { get; set; } = null!;

        [StringLength(250)]
        public string CategoryDesciption { get; set; } = null!;

        public short? ParentCategoryId { get; set; }

        [Required]
        public bool? IsActive { get; set; }
    }
}
