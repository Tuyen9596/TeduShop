//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeduShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Post")]
    public partial class Post
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]

        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alas { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public string Content { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public bool? Status { get; set; }
        public Nullable<bool> HomeFlag { get; set; }
        public Nullable<int> ViewCount { get; set; }
        [ForeignKey("ID")]
        public virtual PostCategorie PostCategories { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
