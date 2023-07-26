namespace ProgChallenge
{
    public class SavingsAcct
    {
        public string _name;
        public string _surname;
        public decimal _interest;
        public decimal _balance;

        public SavingsAcct(string name, string surname, decimal interest, decimal balance)
        {
            _name = name;
            _surname = surname;
            _interest = interest;
            _balance = balance;
        }

        public decimal Deposit(decimal deposit)
        {
            return _balance += deposit;
        }

        public decimal Withdraw(decimal withdrawalAmount)
        {
                return _balance -= withdrawalAmount;
        }

        public decimal ApplyInterest()
        {
            return _balance * _interest;
        }
    }
}