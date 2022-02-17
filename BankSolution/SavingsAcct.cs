
class SavingsAcct : Account
{
    int freeWithdraw;
    decimal interest;
    public SavingsAcct(string name, string surname, decimal interest, decimal balance) : base(name, surname, balance)
    {
        this.interest = interest;
        freeWithdraw = 3;
    }
    public void ApplyInterest()
    {
        balance = (balance * interest) + balance;
    }
    public override void Withdraw(decimal amount)
    {
        if (balance - amount >= 0)
        {
            base.Withdraw(amount);
            freeWithdraw--;
            if (freeWithdraw < 0)
            {
                balance -= 2.00m;
                Console.WriteLine($"More than 3 withdrowals - extra charge");
            }
        }
        else
        {
            Console.WriteLine($"Operation denied:Cannot charge:{amount}");
        }
    }

}
