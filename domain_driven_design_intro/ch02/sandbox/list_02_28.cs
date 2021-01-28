class Money
{
  private readonly decimal amount;
  private readonly string currency;

  public Money(decimal amount, string currency)
  {
    if (currency == null) throw new ArgumentException(nameof(currency));

    this.amount = amount;
    this.currency = currency;
  }
  public Money Add(Money arg)
  {
    if (arg == null) throw new ArgumentException(nameof(arg));
    if (curency != arg.currency) throw ArgumentException($"通貨単位が異なります(this:{currency}, arg:{arg.currency}");
    return new Money(amount + arg.amount, currency);
  }
}
