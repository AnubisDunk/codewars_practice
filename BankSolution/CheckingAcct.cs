
class CheckingAcct : Account
{
    private const decimal OVERDRAW_CHARGE = 35.0m;
    public CheckingAcct(string name, string surname, decimal balance) : base(name, surname, balance){
        
    }
    public override void Withdraw(decimal amount){
        if(amount < balance){
            base.Withdraw(amount);
        }else{
            base.Withdraw(amount+OVERDRAW_CHARGE);
        }
    }

    
    
}
