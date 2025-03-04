﻿using System;

namespace Practik1.ValueObjects
{
    struct Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }

        public string Note { get; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Note = note;
        }

        public override string ToString()
        {
            return $"Date: {Date}\tAmount: {Amount}\tNote: {Note}";
        }
    }
}
