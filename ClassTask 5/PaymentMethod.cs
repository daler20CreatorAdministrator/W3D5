public abstract class PaymentMethod : EntityBase
{
    public string ? DisplayName { get; set; }
    public string ? Provider { get; set; }

    public abstract bool Pay(double amount);

    public virtual double CalculateFee(double amount)
    {
        return 0;
    }

    public override void Validate()
    {
        System.Console.WriteLine("Проверка DisplayName и Provider");
    }
}
