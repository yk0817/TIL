class Money
{
  private readonly decimal amount;
  private readonly string currency;

  public Money(decimal amount, string currency)
  {
    if (currency == null) throw new ArgumentException(nameof(currency));

    this.amount = amount;
    this.currency = this.currency;
  }
}
