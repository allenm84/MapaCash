using System;

namespace Finances
{
  public class SimulationAccountTransaction
  {
    public SimulationAccountTransaction(DateTime date, string description, string sourceId, decimal increase, decimal decrease, decimal balance)
    {
      Date = date;
      Description = description;
      SourceId = sourceId;
      Increase = increase;
      Decrease = decrease;
      Balance = balance;
    }

    public DateTime Date { get; }
    public string Description { get; }
    public string SourceId { get; }
    public decimal Increase { get; }
    public decimal Decrease { get; }
    public decimal Balance { get; }
  }
}