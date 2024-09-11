﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static JurayUniversal.Domain.Enum.Enum;

namespace JurayUniversal.Domain.Models
{
    public class SmsMessage
    {
        public long Id { get; set; }
        public string? SenderId { get; set; }
        public string? Recipients { get; set; }
        public string? MessageContent { get; set; }
        public string? Response { get; set; }
        public string? SummaryReport { get; set; }
        public decimal UnitsUsed { get; set; }
        public DateTime? Scheduleddate { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public MessageStatus Status { get; set; }
      
        public string? Resent { get; set; }


        public string? Response_status { get; set; }
        public string? Response_error_code { get; set; }
        public string? Response_cost { get; set; }
        public string? Response_msg { get; set; }
        public int Response_length { get; set; }
        public int Response_page { get; set; }
        public string? Response_balance { get; set; }

        public string? Response_BalanceResponse { get; set; }

        public long SmsMessageCategoryId { get; set; }
        public SmsMessageCategory SmsMessageCategory { get; set; }
    }
}
