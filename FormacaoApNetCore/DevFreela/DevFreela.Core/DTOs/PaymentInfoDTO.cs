﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.DTOs
{
    public class PaymentInfoDTO
    {
        public PaymentInfoDTO(int idProject, string creditCardNumber, string cvv, string expiresAt, string fullName, decimal amount)
        {
            IdProject = idProject;
            CreditCardNumber = creditCardNumber;
            Cvv = cvv;
            ExpiresAt = expiresAt;
            FullName = fullName;
            Amount = amount;
        }

        public int IdProject { get; private set; }
        public string CreditCardNumber { get; private set; }
        public string Cvv { get; private set; }
        public string ExpiresAt { get; private set; }
        public string FullName { get; private set; }
        public decimal Amount { get; private set; }
    }
}
