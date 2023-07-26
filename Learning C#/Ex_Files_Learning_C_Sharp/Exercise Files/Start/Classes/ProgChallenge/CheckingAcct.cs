namespace ProgChallenge
{
    public class CheckingAcct
    {
        public string _name;
        public string _surname;
        public decimal _balance;
        public CheckingAcct(string name, string surname, decimal balance)
        {
            _name = name;
            _surname = surname;
            _balance = balance;
        }

        public decimal Deposit(decimal deposit)
        {
            return _balance += deposit;
        }

        public decimal Withdraw(decimal withdrawAmount)
        {
                return _balance -= withdrawAmount;
        }

    }
}