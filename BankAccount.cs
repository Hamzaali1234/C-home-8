public class BankAccount
{
    private int AccountId;
    private decimal Balance;
    public string OwerName{get;set;}
    private  bool IsFrozen;

    public BankAccount(int accountId,string owerName, decimal balance)
    {
        AccountId = accountId;
        OwerName = owerName;
        Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        IsFrozen = false;
        if (amount > 0)
        {
            Balance = Balance + amount;
        }
    }

    public void Withdraw(decimal amount)
    {
        IsFrozen = false;
        if (Balance > 0 && Balance > amount)
        {
            Balance = Balance - amount;
        }
    }

    public void FreezeAccount()
    {
        IsFrozen = true;
    }
    public void UnfreezeAccount()
    {
        IsFrozen = false;
    }
}