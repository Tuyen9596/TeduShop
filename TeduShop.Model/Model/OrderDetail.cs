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

    [Table("OrderDetails")]
    public partial class OrderDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string OrderID { get; set; }
        public int ProductID { get; set; }
        public Nullable<int> Quatity { get; set; }
        [ForeignKey("OrderID")]
        public virtual Order Orders { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Products { get; set; }
    }
}
