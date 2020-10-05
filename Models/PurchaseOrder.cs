using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Sandbox.Models
{
    public class PurchaseOrder
    {
        [Key]

        [Required]
        [Display(Name = "Purchase Order Number")]
        public virtual int PurchaseOrderNumber { get; set; }

        public virtual int VendorId { get; set; }

        [Required]
        public virtual string Vendor { get; set; }

        [Required]
        [Display(Name = "Purchase Order Date")]
        public virtual DateTime PoDate { get; set; }

        [Required]
        public virtual decimal Amount { get; set; }
    }
}