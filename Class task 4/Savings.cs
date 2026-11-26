// public class SavingsAccount : BankAccount
// {
//     public double AnnualRate { get; set; }

//     public override double CalculateMonthlyFee()
//     {
//         return 5;
//     }

//     public override void CloseMonth()
//     {
//         Balance += Balance * (AnnualRate / 100);
//         base.CloseMonth();
//     }
// }