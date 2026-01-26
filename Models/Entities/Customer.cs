using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AiChatAPI.Models.Entities;

[Table("Customer")]
public partial class Customer
{
    [Key]
    public long Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LineId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Facebook { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Password { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegisterDate { get; set; }

    public int? UpdateBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? RegisterCode { get; set; }

    public int? FoodTransactionAllianceId { get; set; }

    public int? Status { get; set; }

    [StringLength(50)]
    public string? CustomerImageURL { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<DeliveryTransaction> DeliveryTransactions { get; set; } = new List<DeliveryTransaction>();

    [InverseProperty("Customer")]
    public virtual ICollection<FoodTransactionCustomerEventLog> FoodTransactionCustomerEventLogs { get; set; } = new List<FoodTransactionCustomerEventLog>();

    [InverseProperty("Customer")]
    public virtual ICollection<FoodTransaction> FoodTransactions { get; set; } = new List<FoodTransaction>();
}
