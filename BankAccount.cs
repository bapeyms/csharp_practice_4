namespace csharp_practice_4;

public class BankAccount
{
    public string AccountNumber { get; set; } = String.Empty;
    public string OwnerName { get; set; } = String.Empty;
    public decimal Balance { get; private set; } = decimal.Zero;
    public decimal DailyWithdrawalLimit { get; set; } = decimal.Zero;
    public bool IsBlocked  { get; set; } = false;

    public BankAccount(string accountNumber, string ownerName)
    {
        if (string.IsNullOrWhiteSpace(accountNumber) || string.IsNullOrWhiteSpace(ownerName))
        {
            throw new ArgumentException("Account number and/or owner name cannot be empty!");
        }
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = decimal.Zero;
        DailyWithdrawalLimit = 10000;
    }

    public BankAccount(string accountNumber, string ownerName, decimal balance, decimal dailyWithdrawalLimit)
    {
        if (string.IsNullOrWhiteSpace(accountNumber) || string.IsNullOrWhiteSpace(ownerName))
        {
            throw new ArgumentException("Account number and/or owner name cannot be empty!");
        }
        if (balance < 0)
        {
            throw new ArgumentException("Balance cannot be negative!");
        }
        if (dailyWithdrawalLimit < 0)
        {
            throw new ArgumentException("Daily withdrawal limit cannot be negative!");
        }
        
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = balance;
        DailyWithdrawalLimit = dailyWithdrawalLimit;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
        else
        {
            throw new ArgumentException("Amount cannot be negative!");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Amount cannot be negative!");
        }
        if (IsBlocked)
        {
            throw new InvalidOperationException("This account is blocked!");
        }
        if (amount > DailyWithdrawalLimit)
        {
            throw new InvalidOperationException("Amount cannot be greater than Daily Withdrawal Limit!");
        }

        if (Balance < amount)
        {
            throw new InvalidOperationException("Amount cannot be greater than the Balance!");
        }
        Balance -= amount;
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Balance: {Balance}");
    }
    public void BlockAccount()
    {
        IsBlocked = true;
        Console.WriteLine($"{AccountNumber} is blocked!");
    }
    public void GetAccountInfo()
    {
        Console.WriteLine("--- ACCOUNT INFORMATION ---");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Owner Name: {OwnerName}");
        Console.WriteLine($"Balance: {Balance}");
        Console.WriteLine($"Daily withdrawal limit: {DailyWithdrawalLimit}");
    }
}