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
    public class SystemAccountDto
    {
       
        public short AccountId { get; set; }

        [Display(Name = "Name")]
        public string AccountName { get; set; } = string.Empty;

        [Display(Name = "Email")]
        public string AccountEmail { get; set; } = string.Empty;

        [Display(Name = "Role")]
        public int AccountRole { get; set; }
    }
}
