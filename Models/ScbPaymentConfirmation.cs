using System;
using System.Collections.Generic;

namespace AiChatAPI.Models;

public partial class ScbPaymentConfirmation
{
    public long Id { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? PayeeAccountNumber { get; set; }

    public string? PayerAccountName { get; set; }

    public string? SendingBankCode { get; set; }

    public decimal? Amount { get; set; }

    public string? TransactionId { get; set; }

    public string? TransactionDateandTime { get; set; }

    public string? BillPaymentRef1 { get; set; }

    public string? ConfirmId { get; set; }

    public int? Status { get; set; }

    public string? BillerId { get; set; }
}
