
class CheckingAcct : Account
{
    public CheckingAcct(string name, string surname, decimal balance) : base(name, surname, balance){
        
    }
    public override void Withdraw(decimal ammount){
        if(balance - ammount >= 0){
            base.Withdraw(ammount);
        }else{
            base.Withdraw(ammount+35m);
        }
    }

    
    
}
