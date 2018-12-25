using System;

namespace BondSharp
{
    [Serializable]
    public abstract class Transaction
    {
        protected Transaction(DateTime dateTime, string ticker, decimal moneyAmount)
        {
            DateTime = dateTime;
            Ticker = ticker;
            MoneyAmount = moneyAmount;
        }
        
        public DateTime DateTime { get; set; }
        public string Ticker { get; set; }
        public decimal MoneyAmount { get; set; }
    }

    public class BondTransaction : Transaction
    {
        public BondTransaction(DateTime dateTime, string ticker, decimal moneyAmount) : base(dateTime, ticker, moneyAmount)
        {
        }
        
        public BondState BondState { get; }
    }

    public class CouponTransaction : Transaction
    {
        public CouponTransaction(DateTime dateTime, string ticker, decimal moneyAmount) : base(dateTime, ticker, moneyAmount)
        {
        }
    }
    
    public class MoneyTransaction : Transaction
    {
        public MoneyTransaction(DateTime dateTime, string ticker, decimal moneyAmount) : base(dateTime, ticker, moneyAmount)
        {
        }
    }
}