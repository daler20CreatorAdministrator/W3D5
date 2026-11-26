// public abstract class BankAccount : EntityBase
// {
//     public string ? AccountNumber{ get; set; }
//     public double Balance { get; set; }
//     public void Deposit(double amount)
//     {
//         Balance += amount;
//         System.Console.WriteLine($"Deposit:  {amount}");
//     }
//     public void Withdraw(double amount)
//     {
//         if (Balance >= amount)
//         {
//             Balance -= amount;
//             System.Console.WriteLine($"Withdraw:  {amount}");
//         }
//         else
//         {
//             System.Console.WriteLine("No money");
//         }
//     }
//     public abstract double CalculateMonthlyFee();

//     public virtual void CloseMonth()
//     {
//         Balance -= CalculateMonthlyFee();
//         UpdatedAt = DateTime.UtcNow;
//         System.Console.WriteLine($"Month closed. Balance:  {Balance}");
//     }
//     public override void Validate()
//     {
//         System.Console.WriteLine("Проверка AccountNumber");
//     }
// }
