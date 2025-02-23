﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NguyenHoangLongMVC.Data.Entities;

[Table("NewsArticle")]
public partial class NewsArticle
{
    [Key]
    [Column("NewsArticleID")]
    [StringLength(20)]
    
    public string NewsArticleId { get; set; } = null!;

    [StringLength(400)]
    [Display(Name = "News Title")]
    public string? NewsTitle { get; set; }

    [StringLength(150)]
    public string Headline { get; set; } = null!;

    [Column(TypeName = "datetime")]
    [Display(Name = "Created Date")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(4000)]
    [Display(Name = "News Content")]
    public string? NewsContent { get; set; }

    [StringLength(400)]
    public string? NewsSource { get; set; }

    [Column("CategoryID")]
    public short? CategoryId { get; set; }

    public bool? NewsStatus { get; set; }

    [Column("CreatedByID")]
    public short? CreatedById { get; set; }

    [Column("UpdatedByID")]
    public short? UpdatedById { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("NewsArticles")]
    public virtual Category? Category { get; set; }

    [ForeignKey("CreatedById")]
    [InverseProperty("NewsArticles")]
    [Display(Name = "Created By")]
    public virtual SystemAccount? CreatedBy { get; set; }

    [ForeignKey("NewsArticleId")]
    [InverseProperty("NewsArticles")]
    public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>();
}
