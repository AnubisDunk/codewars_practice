public abstract class Account{
    protected string name {get;set;}
    protected string surname {get;set;}
    protected decimal balance {get;set;}
    public Account(string name, string surname,decimal balance){
        this.name = name;
        this.surname = surname;
        this.balance = balance;
    }
    public void Deposit(decimal ammount)=> balance += ammount;
    public virtual void Withdraw(decimal ammount)=>balance -= ammount;
    public decimal Balance => balance;
    public string AccountOwner => $"{name} {surname}";

    
}