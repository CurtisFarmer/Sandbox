using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sandbox.Models
{
    public class Vendor
    {
        #region Properties

        [Key]
        public int VendorId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Name must be less than 100 characters")]
        public virtual string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Contact must be less than 100 characters")]
        public string Contact { get; set; }

        [Display(Name = "Address Line 1")]
        [Required]
        [StringLength(50, ErrorMessage = "Line 1 must be less than 50 characters")]
        public string Address1 { get; set; }

        [Display(Name = "Address Line 2")]
        [Required]
        [StringLength(50, ErrorMessage = "Line 2 must be less than 50 characters")]
        public string Address2 { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "City must be less than 30 characters")]
        public string City { get; set; }

        [Required]
        [StringLength(2, ErrorMessage = "State must be 2 characters")]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        [Required]
        [StringLength(5, ErrorMessage = "Zip Code must be  5 characters")]
        public string ZipCode { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email must in a valid email format")]
        public string Email { get; set; }

        #endregion
    }
}