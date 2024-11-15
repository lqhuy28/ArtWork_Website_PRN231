using AWS_BusinessObjects.Entities;
using AWS_BusinessObjects.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Common.Models
{
    public class OrderModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "UserAccountId is required")]
        public string? BuyerAccountId { get; set; }

        [Required(ErrorMessage = "OwnerAccountId is required")]
        public string? OwnerAccountId { get; set; }
        [Required(ErrorMessage = "ArtWordID is required")]
        public Guid? ArtWorkID { get; set; }

        public OrderStatus Status { get; set; }
    }
}
