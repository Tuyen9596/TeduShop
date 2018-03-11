namespace TeduShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Menus")]
    public partial class Menus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string URL { get; set; }
        [Required]
        public Nullable<int> GroupID { get; set; }
        public Nullable<int> DIsplayOrder { get; set; }
        public string Target { get; set; }
        [Required]
        public Nullable<bool> Status { get; set; }
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { get; set; }
    }
}
