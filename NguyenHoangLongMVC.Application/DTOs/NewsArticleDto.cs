using NguyenHoangLongMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace NguyenHoangLongMVC.Application.DTOs
{
    public class NewsArticleDto
    {
        public string NewsArticleId { get; set; } = null!;
        [Display(Name = "Title")]
        public string? NewsTitle { get; set; }
        public string Headline { get; set; } = null!;
        [Display(Name = "Date")]
        public DateTime? CreatedDate { get; set; }
        [Display(Name = "Content")]
        public string? NewsContent { get; set; }
        public string? NewsSource { get; set; }
        //public short? CategoryId { get; set; }
        public bool NewsStatus { get; set; }
        //public short? CreatedById { get; set; }
        //public short? UpdatedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public virtual Category? Category { get; set; }
       
        public virtual SystemAccount? CreatedBy { get; set; }
        public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();
    }
}
