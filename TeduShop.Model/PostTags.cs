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
    
    public partial class PostTags
    {
        public int PostID { get; set; }
        public string TagID { get; set; }
        public virtual Tags TagS { get; set; }
        public virtual Post Post { get; set; }

    }
}
