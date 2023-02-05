using System;

namespace ProgChallenge
{
    public class SavingsAcct
    {
        public SavingsAcct (string name, string surname, decimal rate, decimal balance) 
            : base (){

        }

        public decimal Balance { get; set; }
        public string AccountOwner { get; set; }
        public decimal Deposit { get; set; }
    }
}