using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BusinessRuleEngine.Common.Model
{
    /// <summary>
    /// Request model for payment
    /// </summary>
    public class RequestModel
    {
        [Required]
        public PaymentCategoryEnum Category { get; set; }

        [Required]
        [StringLength(1000)]
        public string Address { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        [StringLength(1000)]
        public string EmailAddress { get; set; }

        [StringLength(100)]
        public string Book { get; set; }

        [StringLength(100)]
        public string Video { get; set; }
    }

    public enum PaymentCategoryEnum
    {
        PhysicalProduct = 1,
        Book = 2,
        Membership = 3,
        Upgrade = 4,
        Video = 5
    }
}
