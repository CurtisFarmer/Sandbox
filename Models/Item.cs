using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;


namespace Sandbox.Models
{
    public class Item

    {
        [Key]

        public virtual int ItemID { get; set; }
        
        [Required]
        [StringLength(50, ErrorMessage = "Name must be less than 50 characters")]
        public virtual string Name { get; set; }
        
        [Required]
        [StringLength(200, ErrorMessage = "Description must be less than 200 characters")]
        public virtual string Description { get; set; }
        
        [Display(Name = "Quantity on Hand")]
        [Required]
        public virtual int QuantityOnHand { get; set; }
        
        [Display(Name = "Retail Price")]
        [Required]
        public virtual decimal RetailPrice { get; set; }
        
        [Display(Name = "Standard Cost")]
        [Required]
        public virtual decimal StandardCost { get; set; }
       
        [Display(Name = "Image Location")]
        [Required]
        [StringLength(100, ErrorMessage = "Image Location must be less than 100 characters")]
        public virtual string ImageLocation { get; set; }



    }
}