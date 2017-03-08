//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeduShop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class MenuModel
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(256)]
        public string URL { get; set; }
        public Nullable<int> DisplayOrder { get; set; }

        [MaxLength(10)]
        public string Target { get; set; }
        public Nullable<bool> Status { get; set; }
        [Required]
        public Nullable<int> GroupID { get; set; }
      
    }
}
