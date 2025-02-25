using NguyenHoangLongMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHoangLongMVC.Application.DTOs
{
    public class CategoryDto
    {
       
        [Column("CategoryID")]
        public short CategoryId { get; set; }

        [StringLength(100)]
        public string CategoryName { get; set; } = null!;

        [StringLength(250)]
        public string CategoryDesciption { get; set; } = null!;
        public Category? ParentCategory { get; set; }

        public bool IsActive { get; set; }

    }
}
