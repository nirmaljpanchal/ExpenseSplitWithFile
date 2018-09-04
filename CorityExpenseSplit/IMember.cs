namespace CorityExpenseSplit
{
    public interface IMember
    {
        int ExpenseCount { get; }
        void AddExpense(decimal expense);
        decimal GetTotalExpense();
    }
}