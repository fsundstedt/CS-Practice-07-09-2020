using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Practice_07_09_2020
{
    class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public String Notes { get; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Notes = note;
        }
    }
}
